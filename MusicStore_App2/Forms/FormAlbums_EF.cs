using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormAlbums_EF : Form
    {
        Album album = new Album();

        public FormAlbums_EF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_EnabledChanged(object sender, EventArgs e) // Check why it doesn't work as intended
        {
            if (!btnDelete.Enabled)
            {
                btnDelete.ForeColor = System.Drawing.Color.Gray; // Change the color to gray
            }
            else
            {
                btnDelete.ForeColor = System.Drawing.Color.Red; // Change the color back to red
            }
        }

        void Clear()
        {
            tbArtistID.Text = tbAlbumTitle.Text = tbGenre.Text = tbPublYear.Text = tbRecordLabel.Text = tbPrice.Text = ""; //Empties text boxes with an empty string
            btnInsert.Text = "Save";
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Enabled = false;
            album.album_id = 0;
        }

        private void FormAlbums_EF_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            album.artist_id = Int64.Parse(tbArtistID.Text.Trim());
            album.album_title = tbAlbumTitle.Text.Trim();
            album.genre = tbGenre.Text.Trim();
            album.publ_year = tbPublYear.Text.Trim();
            album.record_label = tbRecordLabel.Text.Trim();
            album.price = Double.Parse(tbPrice.Text.Trim());

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                if (album.album_id == 0)
                {
                    db.Albums.Add(album);
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully inserted.");
                }

                else
                {
                    db.Entry(album).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully updated.");
                }
            }

            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvAlbum.AutoGenerateColumns = false;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                dgvAlbum.DataSource = db.Albums.ToList<Album>();
            }
        }

        private void dgvAlbum_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAlbum.CurrentRow.Index != -1)
            {
                album.album_id = Convert.ToInt64(dgvAlbum.CurrentRow.Cells["tbcAlbumID"].Value);

                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    album = db.Albums.Where(alb => alb.album_id == album.album_id).FirstOrDefault();

                    tbArtistID.Text = album.artist_id.ToString();
                    tbAlbumTitle.Text = album.album_title;
                    tbGenre.Text = album.genre;
                    tbPublYear.Text = album.publ_year;
                    tbRecordLabel.Text = album.record_label;
                    tbPrice.Text = album.price.ToString();
                }

                btnInsert.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Delete database entry", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    var entry = db.Entry(album);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Albums.Attach(album);
                    }

                    db.Albums.Remove(album);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Entry successfully deleted");
                }
            }
        }

    }
}
