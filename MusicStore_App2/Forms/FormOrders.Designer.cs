namespace MusicStore_App2.Forms
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tbcPurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcAlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPurchasedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcPurchaseID,
            this.tbcAlbumID,
            this.tbcCustomerID,
            this.tbcPurchasedAmount,
            this.tbcTotalPaid});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(1012, 552);
            this.dgvOrder.TabIndex = 13;
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellValueChanged);
            this.dgvOrder.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvOrder_UserDeletingRow);
            // 
            // tbcPurchaseID
            // 
            this.tbcPurchaseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcPurchaseID.DataPropertyName = "purchase_id";
            this.tbcPurchaseID.HeaderText = "Purchase ID";
            this.tbcPurchaseID.Name = "tbcPurchaseID";
            this.tbcPurchaseID.ReadOnly = true;
            // 
            // tbcAlbumID
            // 
            this.tbcAlbumID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcAlbumID.DataPropertyName = "album_id";
            this.tbcAlbumID.HeaderText = "Album ID";
            this.tbcAlbumID.Name = "tbcAlbumID";
            this.tbcAlbumID.ReadOnly = true;
            this.tbcAlbumID.Width = 257;
            // 
            // tbcCustomerID
            // 
            this.tbcCustomerID.DataPropertyName = "customer_id";
            this.tbcCustomerID.HeaderText = "Customer ID";
            this.tbcCustomerID.Name = "tbcCustomerID";
            this.tbcCustomerID.ReadOnly = true;
            // 
            // tbcPurchasedAmount
            // 
            this.tbcPurchasedAmount.DataPropertyName = "purchased_amount";
            this.tbcPurchasedAmount.HeaderText = "Amount";
            this.tbcPurchasedAmount.Name = "tbcPurchasedAmount";
            this.tbcPurchasedAmount.ReadOnly = true;
            // 
            // tbcTotalPaid
            // 
            this.tbcTotalPaid.DataPropertyName = "total_paid";
            this.tbcTotalPaid.HeaderText = "Total Paid";
            this.tbcTotalPaid.Name = "tbcTotalPaid";
            this.tbcTotalPaid.ReadOnly = true;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 552);
            this.Controls.Add(this.dgvOrder);
            this.Name = "FormOrders";
            this.Text = "ORDERS";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcAlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPurchasedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTotalPaid;
    }
}