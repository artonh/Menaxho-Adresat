namespace knkV1
{
    partial class frmModifiko
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
            this.btnParaqitAdresat = new System.Windows.Forms.Button();
            this.btnRuajMofiko = new System.Windows.Forms.Button();
            this.dgvKlientiLista = new System.Windows.Forms.DataGridView();
            this.txtKerkoModifiko = new System.Windows.Forms.TextBox();
            this.lblKerkoAdresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientiLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParaqitAdresat
            // 
            this.btnParaqitAdresat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnParaqitAdresat.BackColor = System.Drawing.Color.MistyRose;
            this.btnParaqitAdresat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParaqitAdresat.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaqitAdresat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParaqitAdresat.Location = new System.Drawing.Point(690, 18);
            this.btnParaqitAdresat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParaqitAdresat.Name = "btnParaqitAdresat";
            this.btnParaqitAdresat.Size = new System.Drawing.Size(189, 49);
            this.btnParaqitAdresat.TabIndex = 2;
            this.btnParaqitAdresat.Text = "Shfaq te gjitha";
            this.btnParaqitAdresat.UseVisualStyleBackColor = false;
            this.btnParaqitAdresat.Click += new System.EventHandler(this.btnParaqitAdresat_Click);
            // 
            // btnRuajMofiko
            // 
            this.btnRuajMofiko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRuajMofiko.BackColor = System.Drawing.Color.MistyRose;
            this.btnRuajMofiko.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRuajMofiko.Font = new System.Drawing.Font("Cambria", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuajMofiko.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRuajMofiko.Location = new System.Drawing.Point(690, 531);
            this.btnRuajMofiko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRuajMofiko.Name = "btnRuajMofiko";
            this.btnRuajMofiko.Size = new System.Drawing.Size(189, 49);
            this.btnRuajMofiko.TabIndex = 5;
            this.btnRuajMofiko.Text = "Modifiko adresen";
            this.btnRuajMofiko.UseVisualStyleBackColor = false;
            this.btnRuajMofiko.Click += new System.EventHandler(this.btnRuajMofiko_Click);
            // 
            // dgvKlientiLista
            // 
            this.dgvKlientiLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlientiLista.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvKlientiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlientiLista.Location = new System.Drawing.Point(0, 101);
            this.dgvKlientiLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKlientiLista.MultiSelect = false;
            this.dgvKlientiLista.Name = "dgvKlientiLista";
            this.dgvKlientiLista.ReadOnly = true;
            this.dgvKlientiLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlientiLista.Size = new System.Drawing.Size(896, 421);
            this.dgvKlientiLista.TabIndex = 16;
            // 
            // txtKerkoModifiko
            // 
            this.txtKerkoModifiko.Location = new System.Drawing.Point(199, 31);
            this.txtKerkoModifiko.Margin = new System.Windows.Forms.Padding(4);
            this.txtKerkoModifiko.Name = "txtKerkoModifiko";
            this.txtKerkoModifiko.Size = new System.Drawing.Size(441, 24);
            this.txtKerkoModifiko.TabIndex = 17;
            this.txtKerkoModifiko.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblKerkoAdresa
            // 
            this.lblKerkoAdresa.AutoSize = true;
            this.lblKerkoAdresa.Location = new System.Drawing.Point(144, 34);
            this.lblKerkoAdresa.Name = "lblKerkoAdresa";
            this.lblKerkoAdresa.Size = new System.Drawing.Size(48, 16);
            this.lblKerkoAdresa.TabIndex = 18;
            this.lblKerkoAdresa.Text = "Kerko:";
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
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmModifiko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knkV1.Properties.Resources.f9QW2NW;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKerkoAdresa);
            this.Controls.Add(this.txtKerkoModifiko);
            this.Controls.Add(this.btnRuajMofiko);
            this.Controls.Add(this.btnParaqitAdresat);
            this.Controls.Add(this.dgvKlientiLista);
            this.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifiko";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifiko";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientiLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaqitAdresat;
        private System.Windows.Forms.Button btnRuajMofiko;
        private System.Windows.Forms.DataGridView dgvKlientiLista;
        private System.Windows.Forms.TextBox txtKerkoModifiko;
        private System.Windows.Forms.Label lblKerkoAdresa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}