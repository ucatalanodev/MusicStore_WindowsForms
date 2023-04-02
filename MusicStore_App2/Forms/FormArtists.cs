using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormArtists : Form
    {
        string CONNECTION_STRING = @"Data Source=DESKTOP-URBANO;Initial Catalog=MusicStore;Trusted_connection=true;";


        public FormArtists()
        {
            InitializeComponent();
        }

        private void FormArtists_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Artist", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvArtist.DataSource = dtbl;
            }
        }

        private void dgvArtist_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArtist.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvArtist.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("ArtistAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //INSERT
                    if (dgvRow.Cells["tbcArtistID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@artist_id", 0);
                    }

                    //UPDATE
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@artist_id", dgvRow.Cells["tbcArtistID"].Value);
                    }

                    sqlCmd.Parameters.AddWithValue("@artist_name", dgvRow.Cells["tbcArtistName"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcArtistName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@artist_origin", dgvRow.Cells["tbcArtistOrigin"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcArtistOrigin"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@website", dgvRow.Cells["tbcWebsite"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcWebsite"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@social", dgvRow.Cells["tbcSocial"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcSocial"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@is_band", dgvRow.Cells["cbcIsBand"].Value == DBNull.Value ? "" : dgvRow.Cells["cbcIsBand"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@is_active", dgvRow.Cells["cbcIsActive"].Value == DBNull.Value ? "" : dgvRow.Cells["cbcIsActive"].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
        }

        private void dgvArtist_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly;
            if (dgvArtist.CurrentCell.ColumnIndex == 4)
            {

                e.Control.KeyPress += AllowNumbersOnly;
            }
        }

        private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgvArtist_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvArtist.CurrentRow.Cells["tbcArtistID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Do you want to delete this entry?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("ArtistDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@artist_id", Convert.ToInt64(dgvArtist.CurrentRow.Cells["tbcArtistID"].Value));
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