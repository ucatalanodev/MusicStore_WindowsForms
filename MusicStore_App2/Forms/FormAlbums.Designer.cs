namespace MusicStore_App2.Forms
{
    partial class FormAlbums
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
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.tbcAlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcAlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPublYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcRecordLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcAlbumID,
            this.tbcArtistID,
            this.tbcAlbumTitle,
            this.tbcGenre,
            this.tbcPublYear,
            this.tbcRecordLabel,
            this.tbcPrice});
            this.dgvAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlbum.Location = new System.Drawing.Point(0, 0);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.Size = new System.Drawing.Size(1012, 552);
            this.dgvAlbum.TabIndex = 13;
            this.dgvAlbum.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbum_CellValueChanged);
            this.dgvAlbum.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvAlbum_UserDeletingRow);
            // 
            // tbcAlbumID
            // 
            this.tbcAlbumID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcAlbumID.DataPropertyName = "album_id";
            this.tbcAlbumID.HeaderText = "Album ID";
            this.tbcAlbumID.Name = "tbcAlbumID";
            this.tbcAlbumID.ReadOnly = true;
            // 
            // tbcArtistID
            // 
            this.tbcArtistID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcArtistID.DataPropertyName = "artist_id";
            this.tbcArtistID.HeaderText = "Artist ID";
            this.tbcArtistID.Name = "tbcArtistID";
            // 
            // tbcAlbumTitle
            // 
            this.tbcAlbumTitle.DataPropertyName = "album_title";
            this.tbcAlbumTitle.HeaderText = "Album Title";
            this.tbcAlbumTitle.Name = "tbcAlbumTitle";
            // 
            // tbcGenre
            // 
            this.tbcGenre.DataPropertyName = "genre";
            this.tbcGenre.HeaderText = "Genre";
            this.tbcGenre.Name = "tbcGenre";
            // 
            // tbcPublYear
            // 
            this.tbcPublYear.DataPropertyName = "publ_year";
            this.tbcPublYear.HeaderText = "Publication Year";
            this.tbcPublYear.Name = "tbcPublYear";
            // 
            // tbcRecordLabel
            // 
            this.tbcRecordLabel.DataPropertyName = "record_label";
            this.tbcRecordLabel.HeaderText = "Record Label";
            this.tbcRecordLabel.Name = "tbcRecordLabel";
            this.tbcRecordLabel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbcRecordLabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tbcPrice
            // 
            this.tbcPrice.DataPropertyName = "price";
            this.tbcPrice.HeaderText = "Price";
            this.tbcPrice.Name = "tbcPrice";
            this.tbcPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbcPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 552);
            this.Controls.Add(this.dgvAlbum);
            this.Name = "FormAlbums";
            this.Text = "ALBUMS";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcAlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcAlbumTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPublYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcRecordLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPrice;
    }
}