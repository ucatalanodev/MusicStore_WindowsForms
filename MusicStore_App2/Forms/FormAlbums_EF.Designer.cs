namespace MusicStore_App2.Forms
{
    partial class FormAlbums_EF
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
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbRecordLabel = new System.Windows.Forms.TextBox();
            this.tbPublYear = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRecordLabel = new System.Windows.Forms.Label();
            this.lblPublYear = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbAlbumTitle = new System.Windows.Forms.TextBox();
            this.lblAlbumTitle = new System.Windows.Forms.Label();
            this.tbArtistID = new System.Windows.Forms.TextBox();
            this.lblArtistID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.tbcAlbumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcAlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPublYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcRecordLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panCRUD.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // panCRUD
            // 
            this.panCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panCRUD.Controls.Add(this.btnInsert);
            this.panCRUD.Controls.Add(this.btnDelete);
            this.panCRUD.Controls.Add(this.btnCancel);
            this.panCRUD.Controls.Add(this.tbPrice);
            this.panCRUD.Controls.Add(this.tbRecordLabel);
            this.panCRUD.Controls.Add(this.tbPublYear);
            this.panCRUD.Controls.Add(this.lblPrice);
            this.panCRUD.Controls.Add(this.lblRecordLabel);
            this.panCRUD.Controls.Add(this.lblPublYear);
            this.panCRUD.Controls.Add(this.tbGenre);
            this.panCRUD.Controls.Add(this.lblGenre);
            this.panCRUD.Controls.Add(this.tbAlbumTitle);
            this.panCRUD.Controls.Add(this.lblAlbumTitle);
            this.panCRUD.Controls.Add(this.tbArtistID);
            this.panCRUD.Controls.Add(this.lblArtistID);
            this.panCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panCRUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panCRUD.ForeColor = System.Drawing.Color.White;
            this.panCRUD.Location = new System.Drawing.Point(0, 0);
            this.panCRUD.Margin = new System.Windows.Forms.Padding(4);
            this.panCRUD.Name = "panCRUD";
            this.panCRUD.Size = new System.Drawing.Size(327, 755);
            this.panCRUD.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnInsert.Location = new System.Drawing.Point(0, 593);
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
            this.btnDelete.Location = new System.Drawing.Point(0, 647);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(327, 54);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.EnabledChanged += new System.EventHandler(this.btnDelete_EnabledChanged);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(0, 701);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(327, 54);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(4, 442);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(317, 29);
            this.tbPrice.TabIndex = 3;
            // 
            // tbRecordLabel
            // 
            this.tbRecordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecordLabel.Location = new System.Drawing.Point(4, 355);
            this.tbRecordLabel.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecordLabel.Name = "tbRecordLabel";
            this.tbRecordLabel.Size = new System.Drawing.Size(317, 29);
            this.tbRecordLabel.TabIndex = 3;
            // 
            // tbPublYear
            // 
            this.tbPublYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublYear.Location = new System.Drawing.Point(4, 268);
            this.tbPublYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbPublYear.Name = "tbPublYear";
            this.tbPublYear.Size = new System.Drawing.Size(317, 29);
            this.tbPublYear.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(4, 418);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 23);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // lblRecordLabel
            // 
            this.lblRecordLabel.AutoSize = true;
            this.lblRecordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordLabel.Location = new System.Drawing.Point(4, 331);
            this.lblRecordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordLabel.Name = "lblRecordLabel";
            this.lblRecordLabel.Size = new System.Drawing.Size(109, 23);
            this.lblRecordLabel.TabIndex = 0;
            this.lblRecordLabel.Text = "Record Label";
            // 
            // lblPublYear
            // 
            this.lblPublYear.AutoSize = true;
            this.lblPublYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublYear.Location = new System.Drawing.Point(4, 244);
            this.lblPublYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublYear.Name = "lblPublYear";
            this.lblPublYear.Size = new System.Drawing.Size(132, 23);
            this.lblPublYear.TabIndex = 0;
            this.lblPublYear.Text = "Publication Year";
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(4, 187);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(317, 29);
            this.tbGenre.TabIndex = 2;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(4, 162);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(56, 23);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Genre";
            // 
            // tbAlbumTitle
            // 
            this.tbAlbumTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlbumTitle.Location = new System.Drawing.Point(4, 106);
            this.tbAlbumTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlbumTitle.Name = "tbAlbumTitle";
            this.tbAlbumTitle.Size = new System.Drawing.Size(317, 29);
            this.tbAlbumTitle.TabIndex = 1;
            // 
            // lblAlbumTitle
            // 
            this.lblAlbumTitle.AutoSize = true;
            this.lblAlbumTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumTitle.Location = new System.Drawing.Point(4, 81);
            this.lblAlbumTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbumTitle.Name = "lblAlbumTitle";
            this.lblAlbumTitle.Size = new System.Drawing.Size(97, 23);
            this.lblAlbumTitle.TabIndex = 6;
            this.lblAlbumTitle.Text = "Album Title";
            // 
            // tbArtistID
            // 
            this.tbArtistID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArtistID.Location = new System.Drawing.Point(4, 25);
            this.tbArtistID.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtistID.Name = "tbArtistID";
            this.tbArtistID.Size = new System.Drawing.Size(317, 29);
            this.tbArtistID.TabIndex = 0;
            // 
            // lblArtistID
            // 
            this.lblArtistID.AutoSize = true;
            this.lblArtistID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistID.Location = new System.Drawing.Point(4, 0);
            this.lblArtistID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistID.Name = "lblArtistID";
            this.lblArtistID.Size = new System.Drawing.Size(72, 23);
            this.lblArtistID.TabIndex = 1;
            this.lblArtistID.Text = "Artist ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvAlbum);
            this.panel1.Location = new System.Drawing.Point(328, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 755);
            this.panel1.TabIndex = 2;
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
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
            this.dgvAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.ReadOnly = true;
            this.dgvAlbum.RowHeadersWidth = 51;
            this.dgvAlbum.Size = new System.Drawing.Size(1008, 755);
            this.dgvAlbum.TabIndex = 14;
            this.dgvAlbum.DoubleClick += new System.EventHandler(this.dgvAlbum_DoubleClick);
            // 
            // tbcAlbumID
            // 
            this.tbcAlbumID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbcAlbumID.DataPropertyName = "album_id";
            this.tbcAlbumID.HeaderText = "Album ID";
            this.tbcAlbumID.MinimumWidth = 6;
            this.tbcAlbumID.Name = "tbcAlbumID";
            this.tbcAlbumID.ReadOnly = true;
            // 
            // tbcArtistID
            // 
            this.tbcArtistID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbcArtistID.DataPropertyName = "artist_id";
            this.tbcArtistID.HeaderText = "Artist ID";
            this.tbcArtistID.MinimumWidth = 6;
            this.tbcArtistID.Name = "tbcArtistID";
            this.tbcArtistID.Width = 125;
            // 
            // tbcAlbumTitle
            // 
            this.tbcAlbumTitle.DataPropertyName = "album_title";
            this.tbcAlbumTitle.HeaderText = "Album Title";
            this.tbcAlbumTitle.MinimumWidth = 6;
            this.tbcAlbumTitle.Name = "tbcAlbumTitle";
            // 
            // tbcGenre
            // 
            this.tbcGenre.DataPropertyName = "genre";
            this.tbcGenre.HeaderText = "Genre";
            this.tbcGenre.MinimumWidth = 6;
            this.tbcGenre.Name = "tbcGenre";
            // 
            // tbcPublYear
            // 
            this.tbcPublYear.DataPropertyName = "publ_year";
            this.tbcPublYear.HeaderText = "Publication Year";
            this.tbcPublYear.MinimumWidth = 6;
            this.tbcPublYear.Name = "tbcPublYear";
            // 
            // tbcRecordLabel
            // 
            this.tbcRecordLabel.DataPropertyName = "record_label";
            this.tbcRecordLabel.HeaderText = "Record Label";
            this.tbcRecordLabel.MinimumWidth = 6;
            this.tbcRecordLabel.Name = "tbcRecordLabel";
            this.tbcRecordLabel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbcRecordLabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tbcPrice
            // 
            this.tbcPrice.DataPropertyName = "price";
            this.tbcPrice.HeaderText = "Price";
            this.tbcPrice.MinimumWidth = 6;
            this.tbcPrice.Name = "tbcPrice";
            this.tbcPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbcPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormAlbums_EF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1336, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panCRUD);
            this.Name = "FormAlbums_EF";
            this.Text = "ALBUMS";
            this.Load += new System.EventHandler(this.FormAlbums_EF_Load);
            this.panCRUD.ResumeLayout(false);
            this.panCRUD.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCRUD;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPublYear;
        private System.Windows.Forms.Label lblPublYear;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbAlbumTitle;
        private System.Windows.Forms.Label lblAlbumTitle;
        private System.Windows.Forms.TextBox tbArtistID;
        private System.Windows.Forms.Label lblArtistID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcAlbumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcAlbumTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPublYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcRecordLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbRecordLabel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRecordLabel;
    }
}