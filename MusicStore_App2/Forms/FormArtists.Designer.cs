namespace MusicStore_App2.Forms
{
    partial class FormArtists
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
            this.dgvArtist = new System.Windows.Forms.DataGridView();
            this.tbcArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtistOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbcIsBand = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbcIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtist
            // 
            this.dgvArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.ReadOnly = true;
            this.dgvArtist.Size = new System.Drawing.Size(1012, 552);
            this.dgvArtist.TabIndex = 13;
            this.dgvArtist.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtist_CellValueChanged);
            this.dgvArtist.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvArtist_UserDeletingRow);
            // 
            // tbcArtistID
            // 
            this.tbcArtistID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcArtistID.DataPropertyName = "artist_id";
            this.tbcArtistID.HeaderText = "Artist ID";
            this.tbcArtistID.Name = "tbcArtistID";
            this.tbcArtistID.ReadOnly = true;
            // 
            // tbcArtistName
            // 
            this.tbcArtistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcArtistName.DataPropertyName = "artist_name";
            this.tbcArtistName.HeaderText = "Artist Name";
            this.tbcArtistName.Name = "tbcArtistName";
            this.tbcArtistName.ReadOnly = true;
            this.tbcArtistName.Width = 257;
            // 
            // tbcArtistOrigin
            // 
            this.tbcArtistOrigin.DataPropertyName = "artist_origin";
            this.tbcArtistOrigin.HeaderText = "Artist Origin";
            this.tbcArtistOrigin.Name = "tbcArtistOrigin";
            this.tbcArtistOrigin.ReadOnly = true;
            // 
            // tbcWebsite
            // 
            this.tbcWebsite.DataPropertyName = "website";
            this.tbcWebsite.HeaderText = "Website";
            this.tbcWebsite.Name = "tbcWebsite";
            this.tbcWebsite.ReadOnly = true;
            // 
            // tbcSocial
            // 
            this.tbcSocial.DataPropertyName = "social";
            this.tbcSocial.HeaderText = "Instagram";
            this.tbcSocial.Name = "tbcSocial";
            this.tbcSocial.ReadOnly = true;
            // 
            // cbcIsBand
            // 
            this.cbcIsBand.DataPropertyName = "is_band";
            this.cbcIsBand.HeaderText = "Band";
            this.cbcIsBand.Name = "cbcIsBand";
            this.cbcIsBand.ReadOnly = true;
            // 
            // cbcIsActive
            // 
            this.cbcIsActive.DataPropertyName = "is_active";
            this.cbcIsActive.HeaderText = "Active";
            this.cbcIsActive.Name = "cbcIsActive";
            this.cbcIsActive.ReadOnly = true;
            // 
            // FormArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 552);
            this.Controls.Add(this.dgvArtist);
            this.Name = "FormArtists";
            this.Text = "ARTISTS";
            this.Load += new System.EventHandler(this.FormArtists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcSocial;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsBand;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbcIsActive;
    }
}