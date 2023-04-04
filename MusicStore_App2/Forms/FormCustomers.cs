using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormCustomers : Form
    {
        const string CONNECTION_STRING = @"Data Source=DESKTOP-URBANO;Initial Catalog=MusicStore;Trusted_connection=true;";


        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_Load(object sender, System.EventArgs e)
        {
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Customer", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvCustomer.DataSource = dtbl;
            }
        }

        private void dgvCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvCustomer.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("CustomerAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //INSERT
                    if (dgvRow.Cells["tbcCustomerID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@customer_id", 0);
                    }

                    //UPDATE
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@customer_id", dgvRow.Cells["tbcCustomerID"].Value);
                    }

                    sqlCmd.Parameters.AddWithValue("@customer_name", dgvRow.Cells["tbcCustomerName"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcCustomerName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@customer_address", dgvRow.Cells["tbcCustomerAddress"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcCustomerAddress"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@phone_number", dgvRow.Cells["tbcPhoneNumber"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcPhoneNumber"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@email", dgvRow.Cells["tbcEmail"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcEmail"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@is_business", dgvRow.Cells["cbcIsBusiness"].Value == DBNull.Value ? "" : dgvRow.Cells["cbcIsBusiness"].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
        }

        private void dgvCustomer_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly;
            if (dgvCustomer.CurrentCell.ColumnIndex == 4)
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

            else
            {
                e.Handled = false;
            }
        }

        private void dgvCustomer_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvCustomer.CurrentRow.Cells["tbcCustomerID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Do you want to delete this entry?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("CustomerDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@customer_id", Convert.ToInt64(dgvCustomer.CurrentRow.Cells["tbcCustomerID"].Value));
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