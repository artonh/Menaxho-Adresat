namespace knkV1
{
    partial class frmFshij
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
            this.dgvKlientiLista = new System.Windows.Forms.DataGridView();
            this.btnParaqit = new System.Windows.Forms.Button();
            this.btnFshij = new System.Windows.Forms.Button();
            this.lblKerkoAdresa = new System.Windows.Forms.Label();
            this.txtKerkoModifiko2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientiLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlientiLista
            // 
            this.dgvKlientiLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlientiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlientiLista.Location = new System.Drawing.Point(0, 101);
            this.dgvKlientiLista.MultiSelect = false;
            this.dgvKlientiLista.Name = "dgvKlientiLista";
            this.dgvKlientiLista.ReadOnly = true;
            this.dgvKlientiLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlientiLista.Size = new System.Drawing.Size(896, 421);
            this.dgvKlientiLista.TabIndex = 0;
            // 
            // btnParaqit
            // 
            this.btnParaqit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParaqit.BackColor = System.Drawing.Color.MistyRose;
            this.btnParaqit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParaqit.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.btnParaqit.ForeColor = System.Drawing.Color.Black;
            this.btnParaqit.Location = new System.Drawing.Point(690, 18);
            this.btnParaqit.Margin = new System.Windows.Forms.Padding(2);
            this.btnParaqit.Name = "btnParaqit";
            this.btnParaqit.Size = new System.Drawing.Size(189, 49);
            this.btnParaqit.TabIndex = 1;
            this.btnParaqit.Text = "Shfaq te gjitha";
            this.btnParaqit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnParaqit.UseVisualStyleBackColor = false;
            this.btnParaqit.Click += new System.EventHandler(this.btnParaqit_Click);
            // 
            // btnFshij
            // 
            this.btnFshij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFshij.BackColor = System.Drawing.Color.MistyRose;
            this.btnFshij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFshij.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.btnFshij.ForeColor = System.Drawing.Color.Black;
            this.btnFshij.Location = new System.Drawing.Point(690, 531);
            this.btnFshij.Margin = new System.Windows.Forms.Padding(2);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(189, 49);
            this.btnFshij.TabIndex = 2;
            this.btnFshij.Text = "Largo adresen";
            this.btnFshij.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFshij.UseVisualStyleBackColor = false;
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // lblKerkoAdresa
            // 
            this.lblKerkoAdresa.AutoSize = true;
            this.lblKerkoAdresa.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.lblKerkoAdresa.Location = new System.Drawing.Point(116, 34);
            this.lblKerkoAdresa.Name = "lblKerkoAdresa";
            this.lblKerkoAdresa.Size = new System.Drawing.Size(48, 16);
            this.lblKerkoAdresa.TabIndex = 20;
            this.lblKerkoAdresa.Text = "Kerko:";
            this.lblKerkoAdresa.Click += new System.EventHandler(this.lblKerkoAdresa_Click);
            // 
            // txtKerkoModifiko2
            // 
            this.txtKerkoModifiko2.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.txtKerkoModifiko2.Location = new System.Drawing.Point(171, 31);
            this.txtKerkoModifiko2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKerkoModifiko2.Name = "txtKerkoModifiko2";
            this.txtKerkoModifiko2.Size = new System.Drawing.Size(441, 24);
            this.txtKerkoModifiko2.TabIndex = 19;
            this.txtKerkoModifiko2.TextChanged += new System.EventHandler(this.txtKerkoModifiko_TextChanged);
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
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmFshij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knkV1.Properties.Resources.f9QW2NW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKerkoAdresa);
            this.Controls.Add(this.txtKerkoModifiko2);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.btnParaqit);
            this.Controls.Add(this.dgvKlientiLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFshij";
            this.Text = "Largo adresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientiLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKlientiLista;
        private System.Windows.Forms.Button btnParaqit;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Label lblKerkoAdresa;
        private System.Windows.Forms.TextBox txtKerkoModifiko2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}