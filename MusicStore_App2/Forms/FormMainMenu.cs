using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicStore_App2
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        //Random random;
        //private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            //random = new Random();
        }

        //Methods
        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);

        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }

        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];

        //    return ColorTranslator.FromHtml(color);
        //}

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    //Color color = SelectThemeColor();

                    currentButton = (Button)btnSender;
                    //currentButton.BackColor = color;
                    //currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    ////Changes logo-title panels color according to the color displayed on the selected button
                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
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
            //OpenChildForm(new Forms.FormArtists(), sender);
            OpenChildForm(new Forms.FormArtists_EF(), sender);
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormAlbums(), sender);
            OpenChildForm(new Forms.FormAlbums_EF(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCustomer(), sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders(), sender);
        }
    }
}
