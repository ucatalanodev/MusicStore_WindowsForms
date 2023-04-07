namespace MusicStore_App2.Forms
{
    partial class FormCustomers_EF
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
            this.cbIsBusiness = new System.Windows.Forms.CheckBox();
            this.lblCheckboxes = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panDGV = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tbcCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcIsBusiness = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panCRUD.SuspendLayout();
            this.panDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panCRUD
            // 
            this.panCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panCRUD.Controls.Add(this.cbIsBusiness);
            this.panCRUD.Controls.Add(this.lblCheckboxes);
            this.panCRUD.Controls.Add(this.btnInsert);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnCancel);
            this.panCRUD.Controls.Add(this.tbEmail);
            this.panCRUD.Controls.Add(this.lblEmail);
            this.panCRUD.Controls.Add(this.tbPhoneNumber);
            this.panCRUD.Controls.Add(this.lblPhoneNumber);
            this.panCRUD.Controls.Add(this.tbCustomerAddress);
            this.panCRUD.Controls.Add(this.lblCustomerAddress);
            this.panCRUD.Controls.Add(this.tbCustomerName);
            this.panCRUD.Controls.Add(this.lblCustomerName);
            this.panCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCRUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panCRUD.ForeColor = System.Drawing.Color.White;
            this.panCRUD.Location = new System.Drawing.Point(0, 0);
            this.panCRUD.Margin = new System.Windows.Forms.Padding(4);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(327, 757);
            this.panCRUD.TabIndex = 2;
            // 
            // cbIsBusiness
            // 
            this.cbIsBusiness.AutoSize = true;
            this.cbIsBusiness.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsBusiness.Location = new System.Drawing.Point(157, 351);
            this.cbIsBusiness.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsBusiness.Name = "cbIsBusiness";
            this.cbIsBusiness.Size = new System.Drawing.Size(96, 27);
            this.cbIsBusiness.TabIndex = 10;
            this.cbIsBusiness.Text = "Business";
            this.cbIsBusiness.UseVisualStyleBackColor = true;
            // 
            // lblCheckboxes
            // 
            this.lblCheckboxes.AutoSize = true;
            this.lblCheckboxes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckboxes.Location = new System.Drawing.Point(4, 351);
            this.lblCheckboxes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckboxes.Name = "lblCheckboxes";
            this.lblCheckboxes.Size = new System.Drawing.Size(145, 23);
            this.lblCheckboxes.TabIndex = 9;
            this.lblCheckboxes.Text = "Customer Status: ";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(0, 595);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 649);
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
            this.btnCancel.Location = new System.Drawing.Point(0, 703);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(327, 54);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(4, 288);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(317, 29);
            this.tbEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(4, 264);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(4, 207);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(317, 29);
            this.tbPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(4, 182);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(127, 23);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerAddress.Location = new System.Drawing.Point(4, 126);
            this.tbCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(317, 29);
            this.tbCustomerAddress.TabIndex = 1;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(4, 101);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(149, 23);
            this.lblCustomerAddress.TabIndex = 6;
            this.lblCustomerAddress.Text = "Customer Address";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(4, 45);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(317, 29);
            this.tbCustomerName.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(4, 20);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(135, 23);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // panDGV
            // 
            this.panDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDGV.Controls.Add(this.dgvCustomer);
            this.panDGV.Location = new System.Drawing.Point(329, 0);
            this.panDGV.Margin = new System.Windows.Forms.Padding(4);
            this.panDGV.Name = "panDGV";
            this.panDGV.Size = new System.Drawing.Size(1010, 757);
            this.panDGV.TabIndex = 3;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcCustomerID,
            this.tbcCustomerName,
            this.tbcCustomerAddress,
            this.tbcPhoneNumber,
            this.tbcEmail,
            this.cbcIsBusiness});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(1010, 757);
            this.dgvCustomer.TabIndex = 14;
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // tbcCustomerID
            // 
            this.tbcCustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcCustomerID.DataPropertyName = "customer_id";
            this.tbcCustomerID.HeaderText = "Customer ID";
            this.tbcCustomerID.MinimumWidth = 6;
            this.tbcCustomerID.Name = "tbcCustomerID";
            this.tbcCustomerID.ReadOnly = true;
            // 
            // tbcCustomerName
            // 
            this.tbcCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcCustomerName.DataPropertyName = "customer_name";
            this.tbcCustomerName.HeaderText = "Customer Name";
            this.tbcCustomerName.MinimumWidth = 6;
            this.tbcCustomerName.Name = "tbcCustomerName";
            this.tbcCustomerName.ReadOnly = true;
            this.tbcCustomerName.Width = 257;
            // 
            // tbcCustomerAddress
            // 
            this.tbcCustomerAddress.DataPropertyName = "customer_address";
            this.tbcCustomerAddress.HeaderText = "Customer Address";
            this.tbcCustomerAddress.MinimumWidth = 6;
            this.tbcCustomerAddress.Name = "tbcCustomerAddress";
            this.tbcCustomerAddress.ReadOnly = true;
            // 
            // tbcPhoneNumber
            // 
            this.tbcPhoneNumber.DataPropertyName = "phone_number";
            this.tbcPhoneNumber.HeaderText = "Phone Number";
            this.tbcPhoneNumber.MinimumWidth = 6;
            this.tbcPhoneNumber.Name = "tbcPhoneNumber";
            this.tbcPhoneNumber.ReadOnly = true;
            // 
            // tbcEmail
            // 
            this.tbcEmail.DataPropertyName = "email";
            this.tbcEmail.HeaderText = "E-Mail";
            this.tbcEmail.MinimumWidth = 6;
            this.tbcEmail.Name = "tbcEmail";
            this.tbcEmail.ReadOnly = true;
            // 
            // cbcIsBusiness
            // 
            this.cbcIsBusiness.DataPropertyName = "is_business";
            this.cbcIsBusiness.HeaderText = "Business";
            this.cbcIsBusiness.MinimumWidth = 6;
            this.cbcIsBusiness.Name = "cbcIsBusiness";
            this.cbcIsBusiness.ReadOnly = true;
            // 
            // FormCustomers_EF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1339, 757);
            this.Controls.Add(this.panDGV);
            this.Controls.Add(this.panCRUD);
            this.Name = "FormCustomers_EF";
            this.Text = "FormCustomers_EF";
            this.Load += new System.EventHandler(this.FormCustomers_EF_Load);
            this.panCRUD.ResumeLayout(false);
            this.panCRUD.PerformLayout();
            this.panDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panDGV;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsBusiness;
        private System.Windows.Forms.CheckBox cbIsBusiness;
        private System.Windows.Forms.Label lblCheckboxes;
    }
}