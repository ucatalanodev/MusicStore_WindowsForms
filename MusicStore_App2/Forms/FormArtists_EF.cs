using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormArtists_EF : Form
    {
        Artist artist = new Artist();

        public FormArtists_EF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            tbArtistName.Text = tbArtistOrigin.Text = tbWebsite.Text = tbSocial.Text = ""; //Empties text boxes with an empty string
            cbIsBand.Checked = cbIsActive.Checked = false; //Unchecks checkboxes if previously checked
            btnInsert.Text = "Save";
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Enabled = false;
            artist.artist_id = 0;
        }

        private void FormArtists_EF_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            artist.artist_name = tbArtistName.Text.Trim();
            artist.artist_origin = tbArtistOrigin.Text.Trim();
            artist.website = tbWebsite.Text.Trim();
            artist.social = tbSocial.Text.Trim();
            artist.is_band = cbIsBand.Checked;
            artist.is_active = cbIsActive.Checked;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                if (artist.artist_id == 0)
                {
                    db.Artists.Add(artist);
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully inserted.");
                }

                else
                {
                    db.Entry(artist).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully updated.");
                }
            }

            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvArtist.AutoGenerateColumns = false;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                dgvArtist.DataSource = db.Artists.ToList<Artist>();
            }
        }

        private void dgvArtist_DoubleClick(object sender, EventArgs e)
        {
            if (dgvArtist.CurrentRow.Index != -1)
            {
                artist.artist_id = Convert.ToInt64(dgvArtist.CurrentRow.Cells["tbcArtistID"].Value);

                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    artist = db.Artists.Where(a => a.artist_id == artist.artist_id).FirstOrDefault();

                    tbArtistName.Text = artist.artist_name;
                    tbArtistOrigin.Text = artist.artist_origin;
                    tbWebsite.Text = artist?.website;
                    tbSocial.Text = artist?.social;
                    cbIsBand.Checked = artist.is_band;
                    cbIsActive.Checked = artist.is_active;
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
                    var entry = db.Entry(artist);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Artists.Attach(artist);
                    }

                    db.Artists.Remove(artist);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Entry successfully deleted");
                }
            }
        }
    }
}
