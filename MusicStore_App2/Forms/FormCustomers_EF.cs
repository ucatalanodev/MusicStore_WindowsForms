using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormCustomers_EF : Form
    {
        Customer customer = new Customer();

        public FormCustomers_EF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            tbCustomerName.Text = tbCustomerAddress.Text = tbPhoneNumber.Text = tbEmail.Text = ""; //Empties text boxes with an empty string
            cbIsBusiness.Checked = false; //Unchecks checkboxes if previously checked
            btnInsert.Text = "Save";
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Enabled = false;
            customer.customer_id = 0;
        }

        private void FormCustomers_EF_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            customer.customer_name = tbCustomerName.Text.Trim();
            customer.customer_address = tbCustomerAddress.Text.Trim();
            customer.phone_number = tbPhoneNumber.Text.Trim();
            customer.email = tbEmail.Text.Trim();
            customer.is_business = cbIsBusiness.Checked;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                if (customer.customer_id == 0)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully inserted.");
                }

                else
                {
                    db.Entry(customer).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully updated.");
                }
            }

            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvCustomer.AutoGenerateColumns = false;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                dgvCustomer.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow.Index != -1)
            {
                customer.customer_id = Convert.ToInt64(dgvCustomer.CurrentRow.Cells["tbcCustomerID"].Value);

                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    customer = db.Customers.Where(a => a.customer_id == customer.customer_id).FirstOrDefault();

                    tbCustomerName.Text = customer.customer_name;
                    tbCustomerAddress.Text = customer.customer_address;
                    tbPhoneNumber.Text = customer?.phone_number;
                    tbEmail.Text = customer?.email;
                    cbIsBusiness.Checked = customer.is_business;
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
                    var entry = db.Entry(customer);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Customers.Attach(customer);
                    }

                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Entry successfully deleted");
                }
            }
        }
    }
}
