namespace knkV1
{
    partial class frmKerko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKerko));
            this.dgvAdresa = new System.Windows.Forms.DataGridView();
            this.btnKomuna = new System.Windows.Forms.Button();
            this.btnVendi = new System.Windows.Forms.Button();
            this.btnPozita = new System.Windows.Forms.Button();
            this.btnVendbanimi = new System.Windows.Forms.Button();
            this.btnRruga = new System.Windows.Forms.Button();
            this.pnlMundesi = new System.Windows.Forms.Panel();
            this.btnShfaqTeGjitha = new System.Windows.Forms.Button();
            this.txtKerko = new System.Windows.Forms.TextBox();
            this.grKerko = new System.Windows.Forms.GroupBox();
            this.btnKthehu = new System.Windows.Forms.Button();
            this.grTeGjitha = new System.Windows.Forms.GroupBox();
            this.btnDilNgaTeGjitha = new System.Windows.Forms.Button();
            this.grKerkoPozite = new System.Windows.Forms.GroupBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLongitudeGrKerko = new System.Windows.Forms.TextBox();
            this.lblLatituda = new System.Windows.Forms.Label();
            this.btngrKerkoKerkoPozite = new System.Windows.Forms.Button();
            this.btnKthehuGrKerkoPozite = new System.Windows.Forms.Button();
            this.txtLatitudeGrKerko = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresa)).BeginInit();
            this.pnlMundesi.SuspendLayout();
            this.grKerko.SuspendLayout();
            this.grTeGjitha.SuspendLayout();
            this.grKerkoPozite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdresa
            // 
            this.dgvAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresa.Location = new System.Drawing.Point(2, -201);
            this.dgvAdresa.MultiSelect = false;
            this.dgvAdresa.Name = "dgvAdresa";
            this.dgvAdresa.ReadOnly = true;
            this.dgvAdresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdresa.Size = new System.Drawing.Size(1059, 353);
            this.dgvAdresa.TabIndex = 18;
            this.dgvAdresa.Visible = false;
            // 
            // btnKomuna
            // 
            this.btnKomuna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKomuna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKomuna.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomuna.ForeColor = System.Drawing.Color.Black;
            this.btnKomuna.Location = new System.Drawing.Point(328, 6);
            this.btnKomuna.Margin = new System.Windows.Forms.Padding(2);
            this.btnKomuna.Name = "btnKomuna";
            this.btnKomuna.Size = new System.Drawing.Size(136, 51);
            this.btnKomuna.TabIndex = 2;
            this.btnKomuna.Text = "Filtro sipas Komunes";
            this.btnKomuna.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnKomuna.UseVisualStyleBackColor = false;
            this.btnKomuna.Click += new System.EventHandler(this.btnKomuna_Click);
            // 
            // btnVendi
            // 
            this.btnVendi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendi.ForeColor = System.Drawing.Color.Black;
            this.btnVendi.Location = new System.Drawing.Point(15, 78);
            this.btnVendi.Margin = new System.Windows.Forms.Padding(2);
            this.btnVendi.Name = "btnVendi";
            this.btnVendi.Size = new System.Drawing.Size(136, 51);
            this.btnVendi.TabIndex = 3;
            this.btnVendi.Text = "Filtro sipas vendit";
            this.btnVendi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVendi.UseVisualStyleBackColor = false;
            this.btnVendi.Click += new System.EventHandler(this.btnVendi_Click);
            // 
            // btnPozita
            // 
            this.btnPozita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPozita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPozita.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPozita.ForeColor = System.Drawing.Color.Black;
            this.btnPozita.Location = new System.Drawing.Point(328, 78);
            this.btnPozita.Margin = new System.Windows.Forms.Padding(2);
            this.btnPozita.Name = "btnPozita";
            this.btnPozita.Size = new System.Drawing.Size(136, 51);
            this.btnPozita.TabIndex = 5;
            this.btnPozita.Text = "Filtro sipas pozites";
            this.btnPozita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPozita.UseVisualStyleBackColor = false;
            this.btnPozita.Click += new System.EventHandler(this.btnPozita_Click);
            // 
            // btnVendbanimi
            // 
            this.btnVendbanimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendbanimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendbanimi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendbanimi.ForeColor = System.Drawing.Color.Black;
            this.btnVendbanimi.Location = new System.Drawing.Point(169, 78);
            this.btnVendbanimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnVendbanimi.Name = "btnVendbanimi";
            this.btnVendbanimi.Size = new System.Drawing.Size(136, 51);
            this.btnVendbanimi.TabIndex = 4;
            this.btnVendbanimi.Text = "Filtro sipas nr. te vendbanimit";
            this.btnVendbanimi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnVendbanimi.UseVisualStyleBackColor = false;
            this.btnVendbanimi.Click += new System.EventHandler(this.btnVendbanimi_Click);
            // 
            // btnRruga
            // 
            this.btnRruga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRruga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRruga.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRruga.ForeColor = System.Drawing.Color.Black;
            this.btnRruga.Location = new System.Drawing.Point(169, 6);
            this.btnRruga.Margin = new System.Windows.Forms.Padding(2);
            this.btnRruga.Name = "btnRruga";
            this.btnRruga.Size = new System.Drawing.Size(136, 51);
            this.btnRruga.TabIndex = 1;
            this.btnRruga.Text = "Filtro sipas rruges";
            this.btnRruga.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRruga.UseVisualStyleBackColor = false;
            this.btnRruga.Click += new System.EventHandler(this.btnRruga_Click);
            // 
            // pnlMundesi
            // 
            this.pnlMundesi.BackColor = System.Drawing.Color.Transparent;
            this.pnlMundesi.Controls.Add(this.btnShfaqTeGjitha);
            this.pnlMundesi.Controls.Add(this.btnPozita);
            this.pnlMundesi.Controls.Add(this.btnVendbanimi);
            this.pnlMundesi.Controls.Add(this.btnKomuna);
            this.pnlMundesi.Controls.Add(this.btnRruga);
            this.pnlMundesi.Controls.Add(this.btnVendi);
            this.pnlMundesi.Location = new System.Drawing.Point(234, 0);
            this.pnlMundesi.Name = "pnlMundesi";
            this.pnlMundesi.Size = new System.Drawing.Size(481, 135);
            this.pnlMundesi.TabIndex = 25;
            // 
            // btnShfaqTeGjitha
            // 
            this.btnShfaqTeGjitha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShfaqTeGjitha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShfaqTeGjitha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShfaqTeGjitha.ForeColor = System.Drawing.Color.Black;
            this.btnShfaqTeGjitha.Location = new System.Drawing.Point(15, 6);
            this.btnShfaqTeGjitha.Margin = new System.Windows.Forms.Padding(2);
            this.btnShfaqTeGjitha.Name = "btnShfaqTeGjitha";
            this.btnShfaqTeGjitha.Size = new System.Drawing.Size(136, 51);
            this.btnShfaqTeGjitha.TabIndex = 6;
            this.btnShfaqTeGjitha.Text = "Shfaq te gjitha";
            this.btnShfaqTeGjitha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnShfaqTeGjitha.UseVisualStyleBackColor = false;
            this.btnShfaqTeGjitha.Click += new System.EventHandler(this.btnShfaqTeGjitha_Click);
            // 
            // txtKerko
            // 
            this.txtKerko.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtKerko.Location = new System.Drawing.Point(24, 20);
            this.txtKerko.Name = "txtKerko";
            this.txtKerko.Size = new System.Drawing.Size(290, 26);
            this.txtKerko.TabIndex = 0;
            this.txtKerko.TextChanged += new System.EventHandler(this.txtKerko_TextChanged);
            this.txtKerko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKerko_KeyPress);
            // 
            // grKerko
            // 
            this.grKerko.Controls.Add(this.btnKthehu);
            this.grKerko.Controls.Add(this.txtKerko);
            this.grKerko.Location = new System.Drawing.Point(310, 136);
            this.grKerko.Name = "grKerko";
            this.grKerko.Size = new System.Drawing.Size(329, 115);
            this.grKerko.TabIndex = 28;
            this.grKerko.TabStop = false;
            this.grKerko.Text = "Kerko";
            this.grKerko.Visible = false;
            // 
            // btnKthehu
            // 
            this.btnKthehu.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnKthehu.Location = new System.Drawing.Point(65, 59);
            this.btnKthehu.Name = "btnKthehu";
            this.btnKthehu.Size = new System.Drawing.Size(206, 50);
            this.btnKthehu.TabIndex = 2;
            this.btnKthehu.Text = "Kthehu";
            this.btnKthehu.UseVisualStyleBackColor = true;
            this.btnKthehu.Click += new System.EventHandler(this.btnKthehu_Click);
            // 
            // grTeGjitha
            // 
            this.grTeGjitha.BackColor = System.Drawing.Color.Transparent;
            this.grTeGjitha.Controls.Add(this.btnDilNgaTeGjitha);
            this.grTeGjitha.Location = new System.Drawing.Point(389, 48);
            this.grTeGjitha.Name = "grTeGjitha";
            this.grTeGjitha.Size = new System.Drawing.Size(170, 76);
            this.grTeGjitha.TabIndex = 29;
            this.grTeGjitha.TabStop = false;
            this.grTeGjitha.Text = "Kerko";
            this.grTeGjitha.Visible = false;
            // 
            // btnDilNgaTeGjitha
            // 
            this.btnDilNgaTeGjitha.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnDilNgaTeGjitha.Location = new System.Drawing.Point(23, 19);
            this.btnDilNgaTeGjitha.Name = "btnDilNgaTeGjitha";
            this.btnDilNgaTeGjitha.Size = new System.Drawing.Size(139, 50);
            this.btnDilNgaTeGjitha.TabIndex = 2;
            this.btnDilNgaTeGjitha.Text = "Kthehu";
            this.btnDilNgaTeGjitha.UseVisualStyleBackColor = true;
            this.btnDilNgaTeGjitha.Click += new System.EventHandler(this.btnDilNgaTeGjitha_Click);
            // 
            // grKerkoPozite
            // 
            this.grKerkoPozite.Controls.Add(this.lblLongitude);
            this.grKerkoPozite.Controls.Add(this.txtLongitudeGrKerko);
            this.grKerkoPozite.Controls.Add(this.lblLatituda);
            this.grKerkoPozite.Controls.Add(this.btngrKerkoKerkoPozite);
            this.grKerkoPozite.Controls.Add(this.btnKthehuGrKerkoPozite);
            this.grKerkoPozite.Controls.Add(this.txtLatitudeGrKerko);
            this.grKerkoPozite.Location = new System.Drawing.Point(12, 257);
            this.grKerkoPozite.Name = "grKerkoPozite";
            this.grKerkoPozite.Size = new System.Drawing.Size(329, 130);
            this.grKerkoPozite.TabIndex = 30;
            this.grKerkoPozite.TabStop = false;
            this.grKerkoPozite.Text = "Kerko Sipas Pozites";
            this.grKerkoPozite.Visible = false;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLongitude.Location = new System.Drawing.Point(27, 50);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(81, 18);
            this.lblLongitude.TabIndex = 5;
            this.lblLongitude.Text = "Longitude:";
            // 
            // txtLongitudeGrKerko
            // 
            this.txtLongitudeGrKerko.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLongitudeGrKerko.Location = new System.Drawing.Point(108, 47);
            this.txtLongitudeGrKerko.Name = "txtLongitudeGrKerko";
            this.txtLongitudeGrKerko.Size = new System.Drawing.Size(206, 26);
            this.txtLongitudeGrKerko.TabIndex = 4;
            // 
            // lblLatituda
            // 
            this.lblLatituda.AutoSize = true;
            this.lblLatituda.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLatituda.Location = new System.Drawing.Point(27, 18);
            this.lblLatituda.Name = "lblLatituda";
            this.lblLatituda.Size = new System.Drawing.Size(68, 18);
            this.lblLatituda.TabIndex = 3;
            this.lblLatituda.Text = "Latitude:";
            // 
            // btngrKerkoKerkoPozite
            // 
            this.btngrKerkoKerkoPozite.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btngrKerkoKerkoPozite.Location = new System.Drawing.Point(30, 77);
            this.btngrKerkoKerkoPozite.Name = "btngrKerkoKerkoPozite";
            this.btngrKerkoKerkoPozite.Size = new System.Drawing.Size(139, 50);
            this.btngrKerkoKerkoPozite.TabIndex = 1;
            this.btngrKerkoKerkoPozite.Text = "Kerko";
            this.btngrKerkoKerkoPozite.UseVisualStyleBackColor = true;
            this.btngrKerkoKerkoPozite.Click += new System.EventHandler(this.btngrKerkoKerkoPozite_Click);
            // 
            // btnKthehuGrKerkoPozite
            // 
            this.btnKthehuGrKerkoPozite.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnKthehuGrKerkoPozite.Location = new System.Drawing.Point(175, 77);
            this.btnKthehuGrKerkoPozite.Name = "btnKthehuGrKerkoPozite";
            this.btnKthehuGrKerkoPozite.Size = new System.Drawing.Size(139, 50);
            this.btnKthehuGrKerkoPozite.TabIndex = 2;
            this.btnKthehuGrKerkoPozite.Text = "Kthehu";
            this.btnKthehuGrKerkoPozite.UseVisualStyleBackColor = true;
            this.btnKthehuGrKerkoPozite.Click += new System.EventHandler(this.btnKthehuGrKerkoPozite_Click);
            // 
            // txtLatitudeGrKerko
            // 
            this.txtLatitudeGrKerko.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLatitudeGrKerko.Location = new System.Drawing.Point(108, 15);
            this.txtLatitudeGrKerko.Name = "txtLatitudeGrKerko";
            this.txtLatitudeGrKerko.Size = new System.Drawing.Size(206, 26);
            this.txtLatitudeGrKerko.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::knkV1.Properties.Resources.back1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmKerko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knkV1.Properties.Resources.back5;
            this.ClientSize = new System.Drawing.Size(949, 142);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grKerkoPozite);
            this.Controls.Add(this.grTeGjitha);
            this.Controls.Add(this.grKerko);
            this.Controls.Add(this.pnlMundesi);
            this.Controls.Add(this.dgvAdresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKerko";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kerko adresa";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresa)).EndInit();
            this.pnlMundesi.ResumeLayout(false);
            this.grKerko.ResumeLayout(false);
            this.grKerko.PerformLayout();
            this.grTeGjitha.ResumeLayout(false);
            this.grKerkoPozite.ResumeLayout(false);
            this.grKerkoPozite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdresa;
        private System.Windows.Forms.Button btnKomuna;
        private System.Windows.Forms.Button btnVendi;
        private System.Windows.Forms.Button btnPozita;
        private System.Windows.Forms.Button btnVendbanimi;
        private System.Windows.Forms.Button btnRruga;
        private System.Windows.Forms.Panel pnlMundesi;
        private System.Windows.Forms.TextBox txtKerko;
        private System.Windows.Forms.GroupBox grKerko;
        private System.Windows.Forms.Button btnKthehu;
        private System.Windows.Forms.Button btnShfaqTeGjitha;
        private System.Windows.Forms.GroupBox grTeGjitha;
        private System.Windows.Forms.Button btnDilNgaTeGjitha;
        private System.Windows.Forms.GroupBox grKerkoPozite;
        private System.Windows.Forms.Label lblLatituda;
        private System.Windows.Forms.Button btngrKerkoKerkoPozite;
        private System.Windows.Forms.Button btnKthehuGrKerkoPozite;
        private System.Windows.Forms.TextBox txtLatitudeGrKerko;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLongitudeGrKerko;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}