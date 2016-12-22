namespace knkV1
{
    partial class Kycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kycja));
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNga = new System.Windows.Forms.TextBox();
            this.btnKycu = new System.Windows.Forms.Button();
            this.btnMbylle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(79, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(226, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txtNga
            // 
            this.txtNga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNga.Location = new System.Drawing.Point(79, 61);
            this.txtNga.Name = "txtNga";
            this.txtNga.Size = new System.Drawing.Size(226, 26);
            this.txtNga.TabIndex = 0;
            // 
            // btnKycu
            // 
            this.btnKycu.BackColor = System.Drawing.Color.LightCyan;
            this.btnKycu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKycu.Location = new System.Drawing.Point(91, 191);
            this.btnKycu.Name = "btnKycu";
            this.btnKycu.Size = new System.Drawing.Size(84, 32);
            this.btnKycu.TabIndex = 2;
            this.btnKycu.Text = "Kycu";
            this.btnKycu.UseVisualStyleBackColor = false;
            this.btnKycu.Click += new System.EventHandler(this.btnKycu_Click);
            // 
            // btnMbylle
            // 
            this.btnMbylle.BackColor = System.Drawing.Color.LightCyan;
            this.btnMbylle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMbylle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbylle.Location = new System.Drawing.Point(202, 191);
            this.btnMbylle.Name = "btnMbylle";
            this.btnMbylle.Size = new System.Drawing.Size(84, 32);
            this.btnMbylle.TabIndex = 3;
            this.btnMbylle.Text = "Pastro";
            this.btnMbylle.UseVisualStyleBackColor = false;
            this.btnMbylle.Click += new System.EventHandler(this.btnMbylle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::knkV1.Properties.Resources.back1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kycja
            // 
            this.AcceptButton = this.btnKycu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::knkV1.Properties.Resources.back31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnMbylle;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMbylle);
            this.Controls.Add(this.btnKycu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identifikohu me email";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNga;
        private System.Windows.Forms.Button btnKycu;
        private System.Windows.Forms.Button btnMbylle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}