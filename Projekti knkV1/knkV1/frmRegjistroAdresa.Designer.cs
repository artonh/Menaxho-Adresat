namespace knkV1
{
    partial class frmRegjistroAdresa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegjistroAdresa));
            this.txtRruga = new System.Windows.Forms.TextBox();
            this.lblRruga = new System.Windows.Forms.Label();
            this.lblSqarime = new System.Windows.Forms.Label();
            this.txtSqarime = new System.Windows.Forms.TextBox();
            this.lblShteti = new System.Windows.Forms.Label();
            this.lblVendi = new System.Windows.Forms.Label();
            this.txtNrVendbanimit = new System.Windows.Forms.TextBox();
            this.lblNrV = new System.Windows.Forms.Label();
            this.txtShteti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKomuna = new System.Windows.Forms.Label();
            this.cboKomuna = new System.Windows.Forms.ComboBox();
            this.txtVendi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.btnRegjistro = new System.Windows.Forms.Button();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menaxhimiIAdresaveDataSet = new knkV1.MenaxhimiIAdresaveDataSet();
            this.tblKomunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKomunaTableAdapter = new knkV1.MenaxhimiIAdresaveDataSetTableAdapters.tblKomunaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menaxhimiIAdresaveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKomunaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRruga
            // 
            this.txtRruga.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRruga.Location = new System.Drawing.Point(152, 126);
            this.txtRruga.Name = "txtRruga";
            this.txtRruga.Size = new System.Drawing.Size(305, 26);
            this.txtRruga.TabIndex = 7;
            this.txtRruga.Enter += new System.EventHandler(this.txtRruga_Enter);
            this.txtRruga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRruga_KeyPress);
            // 
            // lblRruga
            // 
            this.lblRruga.AutoSize = true;
            this.lblRruga.BackColor = System.Drawing.Color.Transparent;
            this.lblRruga.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRruga.Location = new System.Drawing.Point(29, 129);
            this.lblRruga.Name = "lblRruga";
            this.lblRruga.Size = new System.Drawing.Size(50, 20);
            this.lblRruga.TabIndex = 6;
            this.lblRruga.Text = "Rruga:";
            // 
            // lblSqarime
            // 
            this.lblSqarime.AutoSize = true;
            this.lblSqarime.BackColor = System.Drawing.Color.Transparent;
            this.lblSqarime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqarime.Location = new System.Drawing.Point(30, 270);
            this.lblSqarime.Name = "lblSqarime";
            this.lblSqarime.Size = new System.Drawing.Size(65, 20);
            this.lblSqarime.TabIndex = 14;
            this.lblSqarime.Text = "Sqarime:";
            // 
            // txtSqarime
            // 
            this.txtSqarime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqarime.Location = new System.Drawing.Point(152, 267);
            this.txtSqarime.Multiline = true;
            this.txtSqarime.Name = "txtSqarime";
            this.txtSqarime.Size = new System.Drawing.Size(305, 98);
            this.txtSqarime.TabIndex = 15;
            this.txtSqarime.Enter += new System.EventHandler(this.txtSqarime_Enter);
            this.txtSqarime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSqarime_KeyPress);
            // 
            // lblShteti
            // 
            this.lblShteti.AutoSize = true;
            this.lblShteti.BackColor = System.Drawing.Color.Transparent;
            this.lblShteti.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShteti.Location = new System.Drawing.Point(30, 19);
            this.lblShteti.Name = "lblShteti";
            this.lblShteti.Size = new System.Drawing.Size(49, 20);
            this.lblShteti.TabIndex = 0;
            this.lblShteti.Text = "Shteti:";
            // 
            // lblVendi
            // 
            this.lblVendi.AutoSize = true;
            this.lblVendi.BackColor = System.Drawing.Color.Transparent;
            this.lblVendi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendi.Location = new System.Drawing.Point(31, 93);
            this.lblVendi.Name = "lblVendi";
            this.lblVendi.Size = new System.Drawing.Size(49, 20);
            this.lblVendi.TabIndex = 4;
            this.lblVendi.Text = "Vendi:";
            // 
            // txtNrVendbanimit
            // 
            this.txtNrVendbanimit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrVendbanimit.Location = new System.Drawing.Point(152, 162);
            this.txtNrVendbanimit.Name = "txtNrVendbanimit";
            this.txtNrVendbanimit.Size = new System.Drawing.Size(305, 26);
            this.txtNrVendbanimit.TabIndex = 9;
            this.txtNrVendbanimit.Enter += new System.EventHandler(this.txtNrVendbanimit_Enter);
            this.txtNrVendbanimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrVendbanimit_KeyPress);
            // 
            // lblNrV
            // 
            this.lblNrV.AutoSize = true;
            this.lblNrV.BackColor = System.Drawing.Color.Transparent;
            this.lblNrV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrV.Location = new System.Drawing.Point(30, 165);
            this.lblNrV.Name = "lblNrV";
            this.lblNrV.Size = new System.Drawing.Size(116, 20);
            this.lblNrV.TabIndex = 8;
            this.lblNrV.Text = "Nr i vendbanimit:";
            // 
            // txtShteti
            // 
            this.txtShteti.Enabled = false;
            this.txtShteti.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShteti.Location = new System.Drawing.Point(152, 16);
            this.txtShteti.Name = "txtShteti";
            this.txtShteti.Size = new System.Drawing.Size(305, 26);
            this.txtShteti.TabIndex = 1;
            this.txtShteti.Text = "Kosova";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 25;
            // 
            // lblKomuna
            // 
            this.lblKomuna.AutoSize = true;
            this.lblKomuna.BackColor = System.Drawing.Color.Transparent;
            this.lblKomuna.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomuna.Location = new System.Drawing.Point(30, 55);
            this.lblKomuna.Name = "lblKomuna";
            this.lblKomuna.Size = new System.Drawing.Size(65, 20);
            this.lblKomuna.TabIndex = 2;
            this.lblKomuna.Text = "Komuna:";
            // 
            // cboKomuna
            // 
            this.cboKomuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboKomuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKomuna.DataSource = this.tblKomunaBindingSource;
            this.cboKomuna.DisplayMember = "Emri";
            this.cboKomuna.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKomuna.FormattingEnabled = true;
            this.cboKomuna.Location = new System.Drawing.Point(152, 52);
            this.cboKomuna.Name = "cboKomuna";
            this.cboKomuna.Size = new System.Drawing.Size(305, 28);
            this.cboKomuna.TabIndex = 3;
            this.cboKomuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboKomuna_KeyPress);
            // 
            // txtVendi
            // 
            this.txtVendi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendi.Location = new System.Drawing.Point(152, 90);
            this.txtVendi.Name = "txtVendi";
            this.txtVendi.Size = new System.Drawing.Size(305, 26);
            this.txtVendi.TabIndex = 5;
            this.txtVendi.Enter += new System.EventHandler(this.txtVendi_Enter);
            this.txtVendi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Longitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Latitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(152, 197);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(305, 26);
            this.txtLatitude.TabIndex = 11;
            this.txtLatitude.Enter += new System.EventHandler(this.txtLatitude_Enter);
            this.txtLatitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitude_KeyPress);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(152, 231);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(305, 26);
            this.txtLongitude.TabIndex = 13;
            this.txtLongitude.Enter += new System.EventHandler(this.txtLongitude_Enter);
            this.txtLongitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongitude_KeyPress);
            // 
            // btnRegjistro
            // 
            this.btnRegjistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegjistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegjistro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegjistro.Image = global::knkV1.Properties.Resources.Save_icon;
            this.btnRegjistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegjistro.Location = new System.Drawing.Point(35, 387);
            this.btnRegjistro.Name = "btnRegjistro";
            this.btnRegjistro.Size = new System.Drawing.Size(190, 66);
            this.btnRegjistro.TabIndex = 16;
            this.btnRegjistro.Text = "Regjistro";
            this.btnRegjistro.UseVisualStyleBackColor = false;
            this.btnRegjistro.Click += new System.EventHandler(this.btnRegjistro_Click);
            // 
            // btnAnulo
            // 
            this.btnAnulo.BackColor = System.Drawing.Color.Transparent;
            this.btnAnulo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnulo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulo.Image = global::knkV1.Properties.Resources.Reset;
            this.btnAnulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulo.Location = new System.Drawing.Point(267, 387);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(190, 66);
            this.btnAnulo.TabIndex = 17;
            this.btnAnulo.Text = "Pastro";
            this.btnAnulo.UseVisualStyleBackColor = false;
            this.btnAnulo.Click += new System.EventHandler(this.btnAnulo_Click);
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
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblKomuna);
            this.panel1.Controls.Add(this.lblRruga);
            this.panel1.Controls.Add(this.txtLongitude);
            this.panel1.Controls.Add(this.txtRruga);
            this.panel1.Controls.Add(this.txtLatitude);
            this.panel1.Controls.Add(this.btnRegjistro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblShteti);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSqarime);
            this.panel1.Controls.Add(this.btnAnulo);
            this.panel1.Controls.Add(this.lblSqarime);
            this.panel1.Controls.Add(this.txtVendi);
            this.panel1.Controls.Add(this.lblVendi);
            this.panel1.Controls.Add(this.cboKomuna);
            this.panel1.Controls.Add(this.lblNrV);
            this.panel1.Controls.Add(this.txtNrVendbanimit);
            this.panel1.Controls.Add(this.txtShteti);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(54, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 469);
            this.panel1.TabIndex = 27;
            // 
            // menaxhimiIAdresaveDataSet
            // 
            this.menaxhimiIAdresaveDataSet.DataSetName = "MenaxhimiIAdresaveDataSet";
            this.menaxhimiIAdresaveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKomunaBindingSource
            // 
            this.tblKomunaBindingSource.DataMember = "tblKomuna";
            this.tblKomunaBindingSource.DataSource = this.menaxhimiIAdresaveDataSet;
            // 
            // tblKomunaTableAdapter
            // 
            this.tblKomunaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegjistroAdresa
            // 
            this.AcceptButton = this.btnRegjistro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnAnulo;
            this.ClientSize = new System.Drawing.Size(594, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegjistroAdresa";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regjistro Vende";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRegjistroAdresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menaxhimiIAdresaveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKomunaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegjistro;
        private System.Windows.Forms.TextBox txtRruga;
        private System.Windows.Forms.Label lblRruga;
        private System.Windows.Forms.Label lblSqarime;
        private System.Windows.Forms.TextBox txtSqarime;
        private System.Windows.Forms.Label lblShteti;
        private System.Windows.Forms.Label lblVendi;
        private System.Windows.Forms.TextBox txtNrVendbanimit;
        private System.Windows.Forms.Label lblNrV;
        private System.Windows.Forms.TextBox txtShteti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKomuna;
        private System.Windows.Forms.ComboBox cboKomuna;
        private System.Windows.Forms.TextBox txtVendi;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MenaxhimiIAdresaveDataSet menaxhimiIAdresaveDataSet;
        private System.Windows.Forms.BindingSource tblKomunaBindingSource;
        private MenaxhimiIAdresaveDataSetTableAdapters.tblKomunaTableAdapter tblKomunaTableAdapter;
    }
}