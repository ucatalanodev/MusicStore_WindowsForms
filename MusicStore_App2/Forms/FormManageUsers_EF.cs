using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormManageUsers_EF : Form
    {
        User user = new User();

        public FormManageUsers_EF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            tbUsername.Text = tbPassword.Text = ""; //Empties text boxes with an empty string
            cbIsActive.Checked = false; //Unchecks checkbox if previously checked
            btnInsert.Text = "Save";
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Enabled = false;
            user.id = 0;
        }

        private void FormManageUsers_EF_Load(object sender, EventArgs e)
        {
            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                comboRole.DataSource = db.Roles.ToList<Role>();
                comboRole.DisplayMember = "name";
                comboRole.ValueMember = "id";
            }

            Clear();
            PopulateDataGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            user.username = tbUsername.Text.Trim();
            user.password = Utils.HashPassword(tbPassword.Text.Trim());
            user.is_active = cbIsActive.Checked;

            // Get the selected role ID from the ComboBox
            int roleid = (int)comboRole.SelectedValue;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                if (user.id == 0)
                {
                    db.Users.Add(user);

                    // Create a new UsersRole object and add it to the database
                    UsersRole userRole = new UsersRole();
                    userRole.userid = user.id;
                    userRole.roleid = roleid;
                    db.UsersRole.Add(userRole);

                    db.SaveChanges();
                    MessageBox.Show("Entry successfully inserted.");
                }

                else
                {
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully updated.");
                }
            }

            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvUser.AutoGenerateColumns = false;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                var query = from u in db.Users
                            join ur in db.UsersRole on u.id equals ur.userid
                            join r in db.Roles on ur.roleid equals r.id
                            select new { u.id, u.username, u.password, u.is_active, r.name };

                dgvUser.DataSource = query.ToList();
            }
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow.Index != -1)
            {
                user.id = Convert.ToInt32(dgvUser.CurrentRow.Cells["tbcUserID"].Value);

                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    user = db.Users.Where(u => u.id == user.id).FirstOrDefault();

                    tbUsername.Text = user.username;
                    tbPassword.Text = user.password;
                    cbIsActive.Checked = (bool)user?.is_active;
                }

                btnInsert.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Delete database entry", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    // Delete the associated UsersRole records
                    var userRoles = db.UsersRole.Where(ur => ur.userid == user.id).ToList();

                    db.UsersRole.RemoveRange(userRoles);

                    // Delete the User record
                    var entry = db.Entry(user);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Users.Attach(user);
                    }

                    db.Users.Remove(user);

                    db.SaveChanges();

                    PopulateDataGridView();
                    Clear();

                    MessageBox.Show("Entry successfully deleted");
                }
            }
        }
    }
}