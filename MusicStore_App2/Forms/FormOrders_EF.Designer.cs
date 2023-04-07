namespace MusicStore_App2.Forms
{
    partial class FormOrders_EF
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
            this.panCRUD = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbTotalPaid = new System.Windows.Forms.TextBox();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.tbPurchasedAmount = new System.Windows.Forms.TextBox();
            this.lblPurchasedAmount = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.tbAlbumID = new System.Windows.Forms.TextBox();
            this.lblAlbumID = new System.Windows.Forms.Label();
            this.panDGV = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tbcPurchaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcAlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPurchasedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcTotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panCRUD.SuspendLayout();
            this.panDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panCRUD
            // 
            this.panCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panCRUD.Controls.Add(this.btnInsert);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnCancel);
            this.panCRUD.Controls.Add(this.tbTotalPaid);
            this.panCRUD.Controls.Add(this.lblTotalPaid);
            this.panCRUD.Controls.Add(this.tbPurchasedAmount);
            this.panCRUD.Controls.Add(this.lblPurchasedAmount);
            this.panCRUD.Controls.Add(this.tbCustomerID);
            this.panCRUD.Controls.Add(this.lblCustomerID);
            this.panCRUD.Controls.Add(this.tbAlbumID);
            this.panCRUD.Controls.Add(this.lblAlbumID);
            this.panCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCRUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panCRUD.ForeColor = System.Drawing.Color.White;
            this.panCRUD.Location = new System.Drawing.Point(0, 0);
            this.panCRUD.Margin = new System.Windows.Forms.Padding(4);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(327, 758);
            this.panCRUD.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(0, 596);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(327, 54);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(0, 650);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(327, 54);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(0, 704);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(327, 54);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTotalPaid
            // 
            this.tbTotalPaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPaid.Location = new System.Drawing.Point(4, 280);
            this.tbTotalPaid.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalPaid.Name = "tbTotalPaid";
            this.tbTotalPaid.Size = new System.Drawing.Size(317, 29);
            this.tbTotalPaid.TabIndex = 3;
            this.tbTotalPaid.TextChanged += new System.EventHandler(this.tbTotalPaid_TextChanged);
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaid.Location = new System.Drawing.Point(4, 256);
            this.lblTotalPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(84, 23);
            this.lblTotalPaid.TabIndex = 0;
            this.lblTotalPaid.Text = "Total Paid";
            this.lblTotalPaid.Click += new System.EventHandler(this.lblTotalPaid_Click);
            // 
            // tbPurchasedAmount
            // 
            this.tbPurchasedAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPurchasedAmount.Location = new System.Drawing.Point(4, 203);
            this.tbPurchasedAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbPurchasedAmount.Name = "tbPurchasedAmount";
            this.tbPurchasedAmount.Size = new System.Drawing.Size(317, 29);
            this.tbPurchasedAmount.TabIndex = 2;
            // 
            // lblPurchasedAmount
            // 
            this.lblPurchasedAmount.AutoSize = true;
            this.lblPurchasedAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedAmount.Location = new System.Drawing.Point(4, 178);
            this.lblPurchasedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchasedAmount.Name = "lblPurchasedAmount";
            this.lblPurchasedAmount.Size = new System.Drawing.Size(156, 23);
            this.lblPurchasedAmount.TabIndex = 7;
            this.lblPurchasedAmount.Text = "Purchased Amount";
            this.lblPurchasedAmount.Click += new System.EventHandler(this.lblPurchasedAmount_Click);
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerID.Location = new System.Drawing.Point(4, 125);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(317, 29);
            this.tbCustomerID.TabIndex = 1;
            this.tbCustomerID.TextChanged += new System.EventHandler(this.tbCustomerID_TextChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(4, 98);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(106, 23);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.Text = "Customer ID";
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // tbAlbumID
            // 
            this.tbAlbumID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlbumID.Location = new System.Drawing.Point(4, 45);
            this.tbAlbumID.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlbumID.Name = "tbAlbumID";
            this.tbAlbumID.Size = new System.Drawing.Size(317, 29);
            this.tbAlbumID.TabIndex = 0;
            // 
            // lblAlbumID
            // 
            this.lblAlbumID.AutoSize = true;
            this.lblAlbumID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumID.Location = new System.Drawing.Point(4, 20);
            this.lblAlbumID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbumID.Name = "lblAlbumID";
            this.lblAlbumID.Size = new System.Drawing.Size(82, 23);
            this.lblAlbumID.TabIndex = 1;
            this.lblAlbumID.Text = "Album ID";
            // 
            // panDGV
            // 
            this.panDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDGV.Controls.Add(this.dgvOrder);
            this.panDGV.Location = new System.Drawing.Point(329, 0);
            this.panDGV.Margin = new System.Windows.Forms.Padding(4);
            this.panDGV.Name = "panDGV";
            this.panDGV.Size = new System.Drawing.Size(1007, 758);
            this.panDGV.TabIndex = 2;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
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
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.Size = new System.Drawing.Size(1007, 758);
            this.dgvOrder.TabIndex = 14;
            this.dgvOrder.DoubleClick += new System.EventHandler(this.dgvOrder_DoubleClick);
            // 
            // tbcPurchaseID
            // 
            this.tbcPurchaseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcPurchaseID.DataPropertyName = "purchase_id";
            this.tbcPurchaseID.HeaderText = "Purchase ID";
            this.tbcPurchaseID.MinimumWidth = 6;
            this.tbcPurchaseID.Name = "tbcPurchaseID";
            this.tbcPurchaseID.ReadOnly = true;
            // 
            // tbcAlbumID
            // 
            this.tbcAlbumID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcAlbumID.DataPropertyName = "album_id";
            this.tbcAlbumID.HeaderText = "Album ID";
            this.tbcAlbumID.MinimumWidth = 6;
            this.tbcAlbumID.Name = "tbcAlbumID";
            this.tbcAlbumID.ReadOnly = true;
            this.tbcAlbumID.Width = 257;
            // 
            // tbcCustomerID
            // 
            this.tbcCustomerID.DataPropertyName = "customer_id";
            this.tbcCustomerID.HeaderText = "Customer ID";
            this.tbcCustomerID.MinimumWidth = 6;
            this.tbcCustomerID.Name = "tbcCustomerID";
            this.tbcCustomerID.ReadOnly = true;
            // 
            // tbcPurchasedAmount
            // 
            this.tbcPurchasedAmount.DataPropertyName = "purchased_amount";
            this.tbcPurchasedAmount.HeaderText = "Amount";
            this.tbcPurchasedAmount.MinimumWidth = 6;
            this.tbcPurchasedAmount.Name = "tbcPurchasedAmount";
            this.tbcPurchasedAmount.ReadOnly = true;
            // 
            // tbcTotalPaid
            // 
            this.tbcTotalPaid.DataPropertyName = "total_paid";
            this.tbcTotalPaid.HeaderText = "Total Paid";
            this.tbcTotalPaid.MinimumWidth = 6;
            this.tbcTotalPaid.Name = "tbcTotalPaid";
            this.tbcTotalPaid.ReadOnly = true;
            // 
            // FormOrders_EF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1336, 758);
            this.Controls.Add(this.panDGV);
            this.Controls.Add(this.panCRUD);
            this.Name = "FormOrders_EF";
            this.Text = "ORDERS";
            this.Load += new System.EventHandler(this.FormOrders_EF_Load);
            this.panCRUD.ResumeLayout(false);
            this.panCRUD.PerformLayout();
            this.panDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbTotalPaid;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.TextBox tbPurchasedAmount;
        private System.Windows.Forms.Label lblPurchasedAmount;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox tbAlbumID;
        private System.Windows.Forms.Label lblAlbumID;
        private System.Windows.Forms.Panel panDGV;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPurchaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcAlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPurchasedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcTotalPaid;
    }
}