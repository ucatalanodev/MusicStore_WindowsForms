using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Form activeForm;
        public User _user;
        public string _roleName;

        //Constructors
        public FormMainMenu()
        {
            InitializeComponent();
        }

        public FormMainMenu(User user)
        {
            InitializeComponent();
            _user = user;
            _roleName = user.UsersRoles.FirstOrDefault().Role.shortname;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
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

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            if (_roleName == "vo")
            {
                OpenChildForm(new Forms.FormArtists(), sender);
            }

            else
            {
                OpenChildForm(new Forms.FormArtists_EF(), sender);
            }
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            if (_roleName == "vo")
            {
                OpenChildForm(new Forms.FormAlbums(), sender);
            }

            else
            {
                OpenChildForm(new Forms.FormAlbums_EF(), sender);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (_roleName == "vo")
            {
                OpenChildForm(new Forms.FormCustomers(), sender);
            }

            else
            {
                OpenChildForm(new Forms.FormCustomers_EF(), sender);
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (_roleName == "vo")
            {
                OpenChildForm(new Forms.FormOrders(), sender);
            }

            else
            {
                OpenChildForm(new Forms.FormOrders_EF(), sender);
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormManageUsers_EF(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.Show();
            Hide();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            if (_roleName != "admin")
            {
                btnManageUsers.Visible = false;
            }
        }
    }
}