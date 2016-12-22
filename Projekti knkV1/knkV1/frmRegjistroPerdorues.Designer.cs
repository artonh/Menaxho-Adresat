namespace knkV1
{
    partial class frmRegjistroPerdorues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegjistroPerdorues));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.lblEmri = new System.Windows.Forms.Label();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.lblGjinia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatelindja = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbtMashkull = new System.Windows.Forms.RadioButton();
            this.rbtFemer = new System.Windows.Forms.RadioButton();
            this.btnKonfirmo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlForma = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlForma.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(24, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(144, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimi.Location = new System.Drawing.Point(144, 58);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.Size = new System.Drawing.Size(250, 26);
            this.txtFjalekalimi.TabIndex = 3;
            this.txtFjalekalimi.UseSystemPasswordChar = true;
            this.txtFjalekalimi.Enter += new System.EventHandler(this.txtFjalekalimi_Enter);
            this.txtFjalekalimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFjalekalimi_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(24, 64);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Fjalekalimi:";
            // 
            // txtEmri
            // 
            this.txtEmri.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmri.Location = new System.Drawing.Point(144, 100);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(250, 26);
            this.txtEmri.TabIndex = 5;
            this.txtEmri.Enter += new System.EventHandler(this.txtEmri_Enter);
            this.txtEmri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmri_KeyPress);
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.BackColor = System.Drawing.Color.Transparent;
            this.lblEmri.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(24, 103);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(43, 20);
            this.lblEmri.TabIndex = 4;
            this.lblEmri.Text = "Emri:";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbiemri.Location = new System.Drawing.Point(144, 142);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(250, 26);
            this.txtMbiemri.TabIndex = 7;
            this.txtMbiemri.Enter += new System.EventHandler(this.txtMbiemri_Enter);
            this.txtMbiemri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMbiemri_KeyPress);
            // 
            // lblMbiemri
            // 
            this.lblMbiemri.AutoSize = true;
            this.lblMbiemri.BackColor = System.Drawing.Color.Transparent;
            this.lblMbiemri.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMbiemri.Location = new System.Drawing.Point(24, 142);
            this.lblMbiemri.Name = "lblMbiemri";
            this.lblMbiemri.Size = new System.Drawing.Size(64, 20);
            this.lblMbiemri.TabIndex = 6;
            this.lblMbiemri.Text = "Mbiemri:";
            // 
            // lblGjinia
            // 
            this.lblGjinia.AutoSize = true;
            this.lblGjinia.BackColor = System.Drawing.Color.Transparent;
            this.lblGjinia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGjinia.Location = new System.Drawing.Point(24, 181);
            this.lblGjinia.Name = "lblGjinia";
            this.lblGjinia.Size = new System.Drawing.Size(50, 20);
            this.lblGjinia.TabIndex = 8;
            this.lblGjinia.Text = "Gjinia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ditelindja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email:";
            // 
            // dtpDatelindja
            // 
            this.dtpDatelindja.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatelindja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatelindja.Location = new System.Drawing.Point(144, 215);
            this.dtpDatelindja.MaxDate = new System.DateTime(8816, 5, 26, 11, 28, 0, 0);
            this.dtpDatelindja.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpDatelindja.Name = "dtpDatelindja";
            this.dtpDatelindja.Size = new System.Drawing.Size(250, 26);
            this.dtpDatelindja.TabIndex = 12;
            this.dtpDatelindja.Value = new System.DateTime(2016, 5, 26, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(144, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // rbtMashkull
            // 
            this.rbtMashkull.AutoSize = true;
            this.rbtMashkull.BackColor = System.Drawing.Color.Transparent;
            this.rbtMashkull.Checked = true;
            this.rbtMashkull.Location = new System.Drawing.Point(144, 181);
            this.rbtMashkull.Name = "rbtMashkull";
            this.rbtMashkull.Size = new System.Drawing.Size(67, 17);
            this.rbtMashkull.TabIndex = 9;
            this.rbtMashkull.TabStop = true;
            this.rbtMashkull.Text = "Mashkull";
            this.rbtMashkull.UseVisualStyleBackColor = false;
            // 
            // rbtFemer
            // 
            this.rbtFemer.AutoSize = true;
            this.rbtFemer.BackColor = System.Drawing.Color.Transparent;
            this.rbtFemer.Location = new System.Drawing.Point(229, 181);
            this.rbtFemer.Name = "rbtFemer";
            this.rbtFemer.Size = new System.Drawing.Size(54, 17);
            this.rbtFemer.TabIndex = 10;
            this.rbtFemer.Text = "Femer";
            this.rbtFemer.UseVisualStyleBackColor = false;
            // 
            // btnKonfirmo
            // 
            this.btnKonfirmo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKonfirmo.BackColor = System.Drawing.Color.Transparent;
            this.btnKonfirmo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKonfirmo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnKonfirmo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKonfirmo.Image = global::knkV1.Properties.Resources.Save_icon;
            this.btnKonfirmo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonfirmo.Location = new System.Drawing.Point(28, 317);
            this.btnKonfirmo.Margin = new System.Windows.Forms.Padding(2);
            this.btnKonfirmo.Name = "btnKonfirmo";
            this.btnKonfirmo.Size = new System.Drawing.Size(183, 66);
            this.btnKonfirmo.TabIndex = 15;
            this.btnKonfirmo.Text = "Konfirmo";
            this.btnKonfirmo.UseVisualStyleBackColor = false;
            this.btnKonfirmo.Click += new System.EventHandler(this.btnKonfirmo_Click);
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
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Image = global::knkV1.Properties.Resources.cancelcon;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(218, 317);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 66);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Pastro";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlForma
            // 
            this.pnlForma.BackColor = System.Drawing.Color.Transparent;
            this.pnlForma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlForma.BackgroundImage")));
            this.pnlForma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForma.Controls.Add(this.lblUsername);
            this.pnlForma.Controls.Add(this.btnReset);
            this.pnlForma.Controls.Add(this.txtUsername);
            this.pnlForma.Controls.Add(this.lblPassword);
            this.pnlForma.Controls.Add(this.rbtFemer);
            this.pnlForma.Controls.Add(this.txtFjalekalimi);
            this.pnlForma.Controls.Add(this.rbtMashkull);
            this.pnlForma.Controls.Add(this.lblEmri);
            this.pnlForma.Controls.Add(this.btnKonfirmo);
            this.pnlForma.Controls.Add(this.txtEmri);
            this.pnlForma.Controls.Add(this.txtEmail);
            this.pnlForma.Controls.Add(this.lblMbiemri);
            this.pnlForma.Controls.Add(this.dtpDatelindja);
            this.pnlForma.Controls.Add(this.txtMbiemri);
            this.pnlForma.Controls.Add(this.label2);
            this.pnlForma.Controls.Add(this.lblGjinia);
            this.pnlForma.Controls.Add(this.label1);
            this.pnlForma.Location = new System.Drawing.Point(81, 68);
            this.pnlForma.Name = "pnlForma";
            this.pnlForma.Size = new System.Drawing.Size(426, 407);
            this.pnlForma.TabIndex = 0;
            // 
            // frmRegjistroPerdorues
            // 
            this.AcceptButton = this.btnKonfirmo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knkV1.Properties.Resources.gray_gradient_wallpaper_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 522);
            this.ControlBox = false;
            this.Controls.Add(this.pnlForma);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegjistroPerdorues";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regjistro Perdorues";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlForma.ResumeLayout(false);
            this.pnlForma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.Label lblGjinia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatelindja;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnKonfirmo;
        private System.Windows.Forms.RadioButton rbtMashkull;
        private System.Windows.Forms.RadioButton rbtFemer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlForma;
    }
}