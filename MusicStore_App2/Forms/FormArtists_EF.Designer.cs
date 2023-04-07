namespace MusicStore_App2.Forms
{
    partial class FormArtists_EF
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
            this.panDGV = new System.Windows.Forms.Panel();
            this.dgvArtist = new System.Windows.Forms.DataGridView();
            this.tbcArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtistOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcIsBand = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbcIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panCRUD = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbIsBand = new System.Windows.Forms.CheckBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.tbSocial = new System.Windows.Forms.TextBox();
            this.lblCheckboxes = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.tbArtistOrigin = new System.Windows.Forms.TextBox();
            this.lblArtistOrigin = new System.Windows.Forms.Label();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.panDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).BeginInit();
            this.panCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDGV
            // 
            this.panDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDGV.Controls.Add(this.dgvArtist);
            this.panDGV.Location = new System.Drawing.Point(329, 0);
            this.panDGV.Margin = new System.Windows.Forms.Padding(4);
            this.panDGV.Name = "panDGV";
            this.panDGV.Size = new System.Drawing.Size(1007, 758);
            this.panDGV.TabIndex = 0;
            // 
            // dgvArtist
            // 
            this.dgvArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArtist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcArtistID,
            this.tbcArtistName,
            this.tbcArtistOrigin,
            this.tbcWebsite,
            this.tbcSocial,
            this.cbcIsBand,
            this.cbcIsActive});
            this.dgvArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtist.Location = new System.Drawing.Point(0, 0);
            this.dgvArtist.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.ReadOnly = true;
            this.dgvArtist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvArtist.RowHeadersWidth = 51;
            this.dgvArtist.Size = new System.Drawing.Size(1007, 758);
            this.dgvArtist.TabIndex = 0;
            this.dgvArtist.DoubleClick += new System.EventHandler(this.dgvArtist_DoubleClick);
            // 
            // tbcArtistID
            // 
            this.tbcArtistID.DataPropertyName = "artist_id";
            this.tbcArtistID.FillWeight = 30F;
            this.tbcArtistID.HeaderText = "Artist ID";
            this.tbcArtistID.MinimumWidth = 20;
            this.tbcArtistID.Name = "tbcArtistID";
            this.tbcArtistID.ReadOnly = true;
            // 
            // tbcArtistName
            // 
            this.tbcArtistName.DataPropertyName = "artist_name";
            this.tbcArtistName.FillWeight = 50F;
            this.tbcArtistName.HeaderText = "Artist Name";
            this.tbcArtistName.MinimumWidth = 6;
            this.tbcArtistName.Name = "tbcArtistName";
            this.tbcArtistName.ReadOnly = true;
            // 
            // tbcArtistOrigin
            // 
            this.tbcArtistOrigin.DataPropertyName = "artist_origin";
            this.tbcArtistOrigin.FillWeight = 34.46341F;
            this.tbcArtistOrigin.HeaderText = "Artist Origin";
            this.tbcArtistOrigin.MinimumWidth = 6;
            this.tbcArtistOrigin.Name = "tbcArtistOrigin";
            this.tbcArtistOrigin.ReadOnly = true;
            // 
            // tbcWebsite
            // 
            this.tbcWebsite.DataPropertyName = "website";
            this.tbcWebsite.FillWeight = 34.46341F;
            this.tbcWebsite.HeaderText = "Website";
            this.tbcWebsite.MinimumWidth = 6;
            this.tbcWebsite.Name = "tbcWebsite";
            this.tbcWebsite.ReadOnly = true;
            // 
            // tbcSocial
            // 
            this.tbcSocial.DataPropertyName = "social";
            this.tbcSocial.FillWeight = 34.46341F;
            this.tbcSocial.HeaderText = "Instagram";
            this.tbcSocial.MinimumWidth = 6;
            this.tbcSocial.Name = "tbcSocial";
            this.tbcSocial.ReadOnly = true;
            // 
            // cbcIsBand
            // 
            this.cbcIsBand.DataPropertyName = "is_band";
            this.cbcIsBand.FillWeight = 34.46341F;
            this.cbcIsBand.HeaderText = "Band";
            this.cbcIsBand.MinimumWidth = 6;
            this.cbcIsBand.Name = "cbcIsBand";
            this.cbcIsBand.ReadOnly = true;
            // 
            // cbcIsActive
            // 
            this.cbcIsActive.DataPropertyName = "is_active";
            this.cbcIsActive.FillWeight = 34.46341F;
            this.cbcIsActive.HeaderText = "Active";
            this.cbcIsActive.MinimumWidth = 6;
            this.cbcIsActive.Name = "cbcIsActive";
            this.cbcIsActive.ReadOnly = true;
            // 
            // panCRUD
            // 
            this.panCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panCRUD.Controls.Add(this.btnInsert);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnCancel);
            this.panCRUD.Controls.Add(this.cbIsBand);
            this.panCRUD.Controls.Add(this.cbIsActive);
            this.panCRUD.Controls.Add(this.tbSocial);
            this.panCRUD.Controls.Add(this.lblCheckboxes);
            this.panCRUD.Controls.Add(this.lblSocial);
            this.panCRUD.Controls.Add(this.tbWebsite);
            this.panCRUD.Controls.Add(this.lblWebsite);
            this.panCRUD.Controls.Add(this.tbArtistOrigin);
            this.panCRUD.Controls.Add(this.lblArtistOrigin);
            this.panCRUD.Controls.Add(this.tbArtistName);
            this.panCRUD.Controls.Add(this.lblArtistName);
            this.panCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCRUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panCRUD.ForeColor = System.Drawing.Color.White;
            this.panCRUD.Location = new System.Drawing.Point(0, 0);
            this.panCRUD.Margin = new System.Windows.Forms.Padding(4);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(327, 758);
            this.panCRUD.TabIndex = 0;
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
            // cbIsBand
            // 
            this.cbIsBand.AutoSize = true;
            this.cbIsBand.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsBand.Location = new System.Drawing.Point(123, 345);
            this.cbIsBand.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsBand.Name = "cbIsBand";
            this.cbIsBand.Size = new System.Drawing.Size(71, 27);
            this.cbIsBand.TabIndex = 4;
            this.cbIsBand.Text = "Band";
            this.cbIsBand.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(211, 345);
            this.cbIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(79, 27);
            this.cbIsActive.TabIndex = 5;
            this.cbIsActive.Text = "Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // tbSocial
            // 
            this.tbSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSocial.Location = new System.Drawing.Point(4, 288);
            this.tbSocial.Margin = new System.Windows.Forms.Padding(4);
            this.tbSocial.Name = "tbSocial";
            this.tbSocial.Size = new System.Drawing.Size(317, 29);
            this.tbSocial.TabIndex = 3;
            // 
            // lblCheckboxes
            // 
            this.lblCheckboxes.AutoSize = true;
            this.lblCheckboxes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckboxes.Location = new System.Drawing.Point(4, 347);
            this.lblCheckboxes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckboxes.Name = "lblCheckboxes";
            this.lblCheckboxes.Size = new System.Drawing.Size(111, 23);
            this.lblCheckboxes.TabIndex = 0;
            this.lblCheckboxes.Text = "Artist Status: ";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocial.Location = new System.Drawing.Point(4, 264);
            this.lblSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(54, 23);
            this.lblSocial.TabIndex = 0;
            this.lblSocial.Text = "Social";
            // 
            // tbWebsite
            // 
            this.tbWebsite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWebsite.Location = new System.Drawing.Point(4, 207);
            this.tbWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(317, 29);
            this.tbWebsite.TabIndex = 2;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.Location = new System.Drawing.Point(4, 182);
            this.lblWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(71, 23);
            this.lblWebsite.TabIndex = 7;
            this.lblWebsite.Text = "Website";
            // 
            // tbArtistOrigin
            // 
            this.tbArtistOrigin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistOrigin.Location = new System.Drawing.Point(4, 126);
            this.tbArtistOrigin.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtistOrigin.Name = "tbArtistOrigin";
            this.tbArtistOrigin.Size = new System.Drawing.Size(317, 29);
            this.tbArtistOrigin.TabIndex = 1;
            // 
            // lblArtistOrigin
            // 
            this.lblArtistOrigin.AutoSize = true;
            this.lblArtistOrigin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistOrigin.Location = new System.Drawing.Point(4, 101);
            this.lblArtistOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistOrigin.Name = "lblArtistOrigin";
            this.lblArtistOrigin.Size = new System.Drawing.Size(102, 23);
            this.lblArtistOrigin.TabIndex = 6;
            this.lblArtistOrigin.Text = "Artist Origin";
            // 
            // tbArtistName
            // 
            this.tbArtistName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistName.Location = new System.Drawing.Point(4, 45);
            this.tbArtistName.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(317, 29);
            this.tbArtistName.TabIndex = 0;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.Location = new System.Drawing.Point(4, 20);
            this.lblArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(101, 23);
            this.lblArtistName.TabIndex = 1;
            this.lblArtistName.Text = "Artist Name";
            // 
            // FormArtists_EF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1336, 758);
            this.Controls.Add(this.panCRUD);
            this.Controls.Add(this.panDGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormArtists_EF";
            this.Text = "ARTISTS";
            this.Load += new System.EventHandler(this.FormArtists_EF_Load);
            this.panDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).EndInit();
            this.panCRUD.ResumeLayout(false);
            this.panCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDGV;
        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.CheckBox cbIsBand;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.TextBox tbSocial;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.TextBox tbArtistOrigin;
        private System.Windows.Forms.Label lblArtistOrigin;
        private System.Windows.Forms.TextBox tbArtistName;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSocial;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsBand;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsActive;
        private System.Windows.Forms.Label lblCheckboxes;
    }
}