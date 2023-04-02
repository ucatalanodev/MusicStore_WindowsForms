using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormAlbums : Form
    {
        const string CONNECTION_STRING = @"Data Source=DESKTOP-URBANO;Initial Catalog=MusicStore;Trusted_connection=true;";


        public FormAlbums()
        {
            InitializeComponent();
        }

        private void FormAlbums_Load(object sender, System.EventArgs e)
        {
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Album", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvAlbum.DataSource = dtbl;
            }
        }

        private void dgvAlbum_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlbum.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvAlbum.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("AlbumAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //INSERT
                    if (dgvRow.Cells["tbcAlbumID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@album_id", 0);
                    }

                    //UPDATE
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@album_id", dgvRow.Cells["tbcAlbumID"].Value);
                    }

                    sqlCmd.Parameters.AddWithValue("@artist_id", dgvRow.Cells["tbcArtistID"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcArtistID"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@album_title", dgvRow.Cells["tbcAlbumTitle"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcAlbumTitle"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@genre", dgvRow.Cells["tbcGenre"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcGenre"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@publ_year", dgvRow.Cells["tbcPublYear"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcPublYear"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@record_label", dgvRow.Cells["tbcRecordLabel"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcRecordLabel"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@price", dgvRow.Cells["tbcPrice"].Value == DBNull.Value ? "" : dgvRow.Cells["tbcPrice"].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    PopulateDataGridView();
                }
            }
        }

        private void dgvAlbum_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvAlbum.CurrentRow.Cells["tbcAlbumID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Do you want to delete this entry?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(CONNECTION_STRING))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("AlbumDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@album_id", Convert.ToInt64(dgvAlbum.CurrentRow.Cells["tbcAlbumID"].Value));
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