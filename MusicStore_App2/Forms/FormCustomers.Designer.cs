namespace MusicStore_App2.Forms
{
    partial class FormCustomer
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tbcCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcIsBusiness = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(1012, 552);
            this.dgvCustomer.TabIndex = 13;
            this.dgvCustomer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellValueChanged);
            this.dgvCustomer.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvCustomer_UserDeletingRow);
            // 
            // tbcCustomerID
            // 
            this.tbcCustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcCustomerID.DataPropertyName = "customer_id";
            this.tbcCustomerID.HeaderText = "Customer ID";
            this.tbcCustomerID.Name = "tbcCustomerID";
            this.tbcCustomerID.ReadOnly = true;
            // 
            // tbcCustomerName
            // 
            this.tbcCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcCustomerName.DataPropertyName = "customer_name";
            this.tbcCustomerName.HeaderText = "Customer Name";
            this.tbcCustomerName.Name = "tbcCustomerName";
            this.tbcCustomerName.Width = 257;
            // 
            // tbcCustomerAddress
            // 
            this.tbcCustomerAddress.DataPropertyName = "customer_address";
            this.tbcCustomerAddress.HeaderText = "Customer Address";
            this.tbcCustomerAddress.Name = "tbcCustomerAddress";
            // 
            // tbcPhoneNumber
            // 
            this.tbcPhoneNumber.DataPropertyName = "phone_number";
            this.tbcPhoneNumber.HeaderText = "Phone Number";
            this.tbcPhoneNumber.Name = "tbcPhoneNumber";
            // 
            // tbcEmail
            // 
            this.tbcEmail.DataPropertyName = "email";
            this.tbcEmail.HeaderText = "E-Mail";
            this.tbcEmail.Name = "tbcEmail";
            // 
            // cbcIsBusiness
            // 
            this.cbcIsBusiness.DataPropertyName = "is_business";
            this.cbcIsBusiness.HeaderText = "Business";
            this.cbcIsBusiness.Name = "cbcIsBusiness";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 552);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "FormCustomer";
            this.Text = "CUSTOMERS";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsBusiness;
    }
}