using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace MusicStore_App2.Forms
{
    public partial class FormOrders_EF : Form
    {
        Purchase purchase = new Purchase();

        public FormOrders_EF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            tbAlbumID.Text = tbCustomerID.Text = tbPurchasedAmount.Text = tbTotalPaid.Text = ""; //Empties text boxes with an empty string
            btnInsert.Text = "Save";
            btnDelete.ForeColor = System.Drawing.Color.Red;
            btnDelete.Enabled = false;
            purchase.purchase_id = 0;
        }

        private void FormOrders_EF_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            purchase.album_id = Int64.Parse(tbAlbumID.Text.Trim());
            purchase.customer_id = Int64.Parse(tbCustomerID.Text.Trim());
            purchase.purchased_amount = tbPurchasedAmount.Text.Trim();
            purchase.total_paid = Double.Parse(tbTotalPaid.Text.Trim());

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                if (purchase.purchase_id == 0)
                {
                    db.Purchases.Add(purchase);
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully inserted.");
                }

                else
                {
                    db.Entry(purchase).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Entry successfully updated.");
                }
            }

            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvOrder.AutoGenerateColumns = false;

            using (MusicStoreEntities db = new MusicStoreEntities())
            {
                dgvOrder.DataSource = db.Purchases.ToList<Purchase>();
            }
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow.Index != -1)
            {
                purchase.purchase_id = Convert.ToInt64(dgvOrder.CurrentRow.Cells["tbcpurchaseID"].Value);

                using (MusicStoreEntities db = new MusicStoreEntities())
                {
                    purchase = db.Purchases.Where(a => a.purchase_id == purchase.purchase_id).FirstOrDefault();

                    tbAlbumID.Text = purchase.album_id.ToString();
                    tbCustomerID.Text = purchase.customer_id.ToString();
                    tbPurchasedAmount.Text = purchase?.purchased_amount;
                    tbTotalPaid.Text = purchase?.total_paid.ToString();
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
                    var entry = db.Entry(purchase);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Purchases.Attach(purchase);
                    }

                    db.Purchases.Remove(purchase);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Entry successfully deleted");
                }
            }
        }

        private void lblPurchasedAmount_Click(object sender, EventArgs e)
        {

        }

        private void tbTotalPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalPaid_Click(object sender, EventArgs e)
        {

        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}
