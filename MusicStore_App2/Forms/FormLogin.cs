using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            _db = new MusicStoreEntities();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private readonly MusicStoreEntities _db;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUsername.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.HashPassword(password);

                //Check for matching username, password and active flag
                var user = _db.Users.FirstOrDefault(u => u.username == username && u.password == hashed_password && u.is_active == true);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials.");
                }

                else
                {
                    var mainMenu = new FormMainMenu(user);
                    mainMenu.Show();
                    Hide();
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Something went wrong, please try again.");
            }
        }
    }
}
