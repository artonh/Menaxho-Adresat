namespace knkV1
{
    partial class frmShtoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShtoAdmin));
            this.txtKerkoModifiko2 = new System.Windows.Forms.TextBox();
            this.btnParaqit = new System.Windows.Forms.Button();
            this.dgvKlientiLista = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientiLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKerkoModifiko2
            // 
            this.txtKerkoModifiko2.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.txtKerkoModifiko2.Location = new System.Drawing.Point(107, 35);
            this.txtKerkoModifiko2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKerkoModifiko2.Name = "txtKerkoModifiko2";
            this.txtKerkoModifiko2.Size = new System.Drawing.Size(332, 24);
            this.txtKerkoModifiko2.TabIndex = 23;
            // 
            // btnParaqit
            // 
            this.btnParaqit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParaqit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnParaqit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParaqit.Font = new System.Drawing.Font("Cambria", 10.5F);
            this.btnParaqit.ForeColor = System.Drawing.Color.Black;
            this.btnParaqit.Location = new System.Drawing.Point(464, 22);
            this.btnParaqit.Margin = new System.Windows.Forms.Padding(2);
            this.btnParaqit.Name = "btnParaqit";
            this.btnParaqit.Size = new System.Drawing.Size(117, 48);
            this.btnParaqit.TabIndex = 22;
            this.btnParaqit.Text = "Shto si admin";
            this.btnParaqit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnParaqit.UseVisualStyleBackColor = false;
            this.btnParaqit.Click += new System.EventHandler(this.btnParaqit_Click);
            // 
            // dgvKlientiLista
            // 
            this.dgvKlientiLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlientiLista.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvKlientiLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlientiLista.Location = new System.Drawing.Point(-2, 98);
            this.dgvKlientiLista.MultiSelect = false;
            this.dgvKlientiLista.Name = "dgvKlientiLista";
            this.dgvKlientiLista.ReadOnly = true;
            this.dgvKlientiLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlientiLista.Size = new System.Drawing.Size(595, 367);
            this.dgvKlientiLista.TabIndex = 21;
            this.dgvKlientiLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlientiLista_CellContentClick);
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
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmShtoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(592, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKerkoModifiko2);
            this.Controls.Add(this.btnParaqit);
            this.Controls.Add(this.dgvKlientiLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmShtoAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShtoAdmin";
            this.Load += new System.EventHandler(this.frmShtoAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlientiLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKerkoModifiko2;
        private System.Windows.Forms.Button btnParaqit;
        private System.Windows.Forms.DataGridView dgvKlientiLista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}