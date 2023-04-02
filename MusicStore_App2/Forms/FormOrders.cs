using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormOrders : Form
    {
        const string CONNECTION_STRING = @"Data Source=DESKTOP-URBANO;Initial Catalog=MusicStore;Trusted_connection=true;";


        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, System.EventArgs e)
        {
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Purchase", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvOrder.DataSource = dtbl;
            }
        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //se griglia.cella = not null, se altri ... altrimenti no -- solo if non else

            if (dgvOrder.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvOrder.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("PurchaseAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //INSERT
                    if (dgvRow.Cells["tbcPurchaseID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@purchase_id", 0);
                    }

                    //UPDATE
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@purchase_id", dgvRow.Cells["tbcPurchaseID"].Value);
                    }

                    sqlCmd.Parameters.AddWithValue("@album_id", dgvRow.Cells["tbcAlbumID"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcAlbumID"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@customer_id", dgvRow.Cells["tbcCustomerID"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcCustomerID"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@purchased_amount", dgvRow.Cells["tbcPurchasedAmount"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcPurchasedAmount"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@total_paid", dgvRow.Cells["tbcTotalPaid"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcTotalPaid"].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
        }

        private void dgvOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly;
            if (dgvOrder.CurrentCell.ColumnIndex == 4)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvOrder_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvOrder.CurrentRow.Cells["tbcPurchaseID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Do you want to delete this entry?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("PurchaseDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@purchase_id", Convert.ToInt64(dgvOrder.CurrentRow.Cells["tbcPurchaseID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}