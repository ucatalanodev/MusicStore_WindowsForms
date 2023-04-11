namespace MusicStore_App2.Forms
{
    partial class FormManageUsers_EF
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
            this.lblRole = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panDGV = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tbcUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panCRUD.SuspendLayout();
            this.panDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panCRUD
            // 
            this.panCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panCRUD.Controls.Add(this.lblRole);
            this.panCRUD.Controls.Add(this.comboRole);
            this.panCRUD.Controls.Add(this.lblUserStatus);
            this.panCRUD.Controls.Add(this.cbIsActive);
            this.panCRUD.Controls.Add(this.btnInsert);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnCancel);
            this.panCRUD.Controls.Add(this.tbPassword);
            this.panCRUD.Controls.Add(this.lblPassword);
            this.panCRUD.Controls.Add(this.tbUsername);
            this.panCRUD.Controls.Add(this.lblUsername);
            this.panCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCRUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panCRUD.ForeColor = System.Drawing.Color.White;
            this.panCRUD.Location = new System.Drawing.Point(0, 0);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(245, 744);
            this.panCRUD.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(3, 176);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 17);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role";
            // 
            // comboRole
            // 
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(3, 196);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(239, 25);
            this.comboRole.TabIndex = 11;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Location = new System.Drawing.Point(3, 244);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(80, 17);
            this.lblUserStatus.TabIndex = 10;
            this.lblUserStatus.Text = "User Status:";
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(89, 244);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(64, 21);
            this.cbIsActive.TabIndex = 9;
            this.cbIsActive.Text = "Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(0, 612);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(245, 44);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 656);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 44);
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
            this.btnCancel.Location = new System.Drawing.Point(0, 700);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(245, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(3, 114);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(239, 25);
            this.tbPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(3, 37);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(239, 25);
            this.tbUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // panDGV
            // 
            this.panDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDGV.Controls.Add(this.dgvUser);
            this.panDGV.Location = new System.Drawing.Point(248, 0);
            this.panDGV.Name = "panDGV";
            this.panDGV.Size = new System.Drawing.Size(1178, 744);
            this.panDGV.TabIndex = 4;
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcUserID,
            this.tbcUsername,
            this.tbcPassword,
            this.tbcRole,
            this.cbcIsActive});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(1178, 744);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // tbcUserID
            // 
            this.tbcUserID.DataPropertyName = "id";
            this.tbcUserID.HeaderText = "User ID";
            this.tbcUserID.Name = "tbcUserID";
            this.tbcUserID.ReadOnly = true;
            // 
            // tbcUsername
            // 
            this.tbcUsername.DataPropertyName = "username";
            this.tbcUsername.HeaderText = "Username";
            this.tbcUsername.Name = "tbcUsername";
            this.tbcUsername.ReadOnly = true;
            // 
            // tbcPassword
            // 
            this.tbcPassword.DataPropertyName = "password";
            this.tbcPassword.HeaderText = "Password";
            this.tbcPassword.Name = "tbcPassword";
            this.tbcPassword.ReadOnly = true;
            // 
            // tbcRole
            // 
            this.tbcRole.DataPropertyName = "name";
            this.tbcRole.HeaderText = "Role";
            this.tbcRole.Name = "tbcRole";
            this.tbcRole.ReadOnly = true;
            // 
            // cbcIsActive
            // 
            this.cbcIsActive.DataPropertyName = "is_active";
            this.cbcIsActive.HeaderText = "Active";
            this.cbcIsActive.Name = "cbcIsActive";
            this.cbcIsActive.ReadOnly = true;
            // 
            // FormManageUsers_EF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1426, 744);
            this.Controls.Add(this.panDGV);
            this.Controls.Add(this.panCRUD);
            this.Name = "FormManageUsers_EF";
            this.Text = "USER MANAGEMENT";
            this.Load += new System.EventHandler(this.FormManageUsers_EF_Load);
            this.panCRUD.ResumeLayout(false);
            this.panCRUD.PerformLayout();
            this.panDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panDGV;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsActive;
    }
}