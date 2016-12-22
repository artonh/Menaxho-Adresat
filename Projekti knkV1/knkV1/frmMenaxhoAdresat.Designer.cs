namespace knkV1
{
    partial class frmMenaxhoAdresat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenaxhoAdresat));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlLogimi = new System.Windows.Forms.Panel();
            this.llRegjistrohu = new System.Windows.Forms.LinkLabel();
            this.pcbFjalekalimi = new System.Windows.Forms.PictureBox();
            this.pcbPerdoruesi = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.tmrKohaShfaqjes = new System.Windows.Forms.Timer(this.components);
            this.pnlVeglat = new System.Windows.Forms.Panel();
            this.btnKontakt = new System.Windows.Forms.Button();
            this.btnShtoAdmin = new System.Windows.Forms.Button();
            this.btnRrethNesh = new System.Windows.Forms.Button();
            this.pnlGjuhet = new System.Windows.Forms.Panel();
            this.rbtEn = new System.Windows.Forms.RadioButton();
            this.rbtShqip = new System.Windows.Forms.RadioButton();
            this.lblRegjistro = new System.Windows.Forms.Label();
            this.lblFshij = new System.Windows.Forms.Label();
            this.pbPerdoruesi = new System.Windows.Forms.PictureBox();
            this.lblModifiko = new System.Windows.Forms.Label();
            this.lblEmriUserit = new System.Windows.Forms.Label();
            this.btnFshij = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.lblKerko = new System.Windows.Forms.Label();
            this.btnKekro = new System.Windows.Forms.Button();
            this.btnGjuha = new System.Windows.Forms.Button();
            this.btnNdihma = new System.Windows.Forms.Button();
            this.btnRegjistro = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ToolStrip();
            this.tsdOpsione = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlsMbyll = new System.Windows.Forms.ToolStripMenuItem();
            this.tstGjuha = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstShqip = new System.Windows.Forms.ToolStripMenuItem();
            this.tstAnglisht = new System.Windows.Forms.ToolStripMenuItem();
            this.tstNdihma = new System.Windows.Forms.ToolStripDropDownButton();
            this.tstNdihma_Ndihma = new System.Windows.Forms.ToolStripMenuItem();
            this.tstNdihma_Kontakto = new System.Windows.Forms.ToolStripMenuItem();
            this.tstNdihma_Rrethnesh = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstKohaAktuale = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstKoha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstStatistika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrOra = new System.Windows.Forms.Timer(this.components);
            this.tmrKohaEMbylljes = new System.Windows.Forms.Timer(this.components);
            this.pnlLogimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFjalekalimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerdoruesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlVeglat.SuspendLayout();
            this.pnlGjuhet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerdoruesi)).BeginInit();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(41, 214);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(150, 26);
            this.txtUser.TabIndex = 0;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(41, 251);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(150, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // pnlLogimi
            // 
            this.pnlLogimi.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogimi.Controls.Add(this.llRegjistrohu);
            this.pnlLogimi.Controls.Add(this.pcbFjalekalimi);
            this.pnlLogimi.Controls.Add(this.pcbPerdoruesi);
            this.pnlLogimi.Controls.Add(this.pictureBox1);
            this.pnlLogimi.Controls.Add(this.btnLog);
            this.pnlLogimi.Controls.Add(this.txtUser);
            this.pnlLogimi.Controls.Add(this.txtPass);
            this.pnlLogimi.Location = new System.Drawing.Point(12, 35);
            this.pnlLogimi.Name = "pnlLogimi";
            this.pnlLogimi.Size = new System.Drawing.Size(214, 390);
            this.pnlLogimi.TabIndex = 2;
            // 
            // llRegjistrohu
            // 
            this.llRegjistrohu.AutoSize = true;
            this.llRegjistrohu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.llRegjistrohu.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llRegjistrohu.Location = new System.Drawing.Point(21, 348);
            this.llRegjistrohu.Name = "llRegjistrohu";
            this.llRegjistrohu.Size = new System.Drawing.Size(80, 17);
            this.llRegjistrohu.TabIndex = 3;
            this.llRegjistrohu.TabStop = true;
            this.llRegjistrohu.Text = "Regjistrohu";
            this.llRegjistrohu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegjistrohu_LinkClicked);
            // 
            // pcbFjalekalimi
            // 
            this.pcbFjalekalimi.Image = ((System.Drawing.Image)(resources.GetObject("pcbFjalekalimi.Image")));
            this.pcbFjalekalimi.Location = new System.Drawing.Point(12, 251);
            this.pcbFjalekalimi.Margin = new System.Windows.Forms.Padding(2);
            this.pcbFjalekalimi.Name = "pcbFjalekalimi";
            this.pcbFjalekalimi.Size = new System.Drawing.Size(26, 26);
            this.pcbFjalekalimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFjalekalimi.TabIndex = 15;
            this.pcbFjalekalimi.TabStop = false;
            // 
            // pcbPerdoruesi
            // 
            this.pcbPerdoruesi.Image = ((System.Drawing.Image)(resources.GetObject("pcbPerdoruesi.Image")));
            this.pcbPerdoruesi.Location = new System.Drawing.Point(12, 215);
            this.pcbPerdoruesi.Margin = new System.Windows.Forms.Padding(2);
            this.pcbPerdoruesi.Name = "pcbPerdoruesi";
            this.pcbPerdoruesi.Size = new System.Drawing.Size(26, 26);
            this.pcbPerdoruesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPerdoruesi.TabIndex = 14;
            this.pcbPerdoruesi.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 164);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.White;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(24, 290);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(167, 43);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Kyçu";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLOG_Click);
            // 
            // tmrKohaShfaqjes
            // 
            this.tmrKohaShfaqjes.Interval = 20;
            this.tmrKohaShfaqjes.Tick += new System.EventHandler(this.tmrKohaShfaqjes_Tick);
            // 
            // pnlVeglat
            // 
            this.pnlVeglat.BackColor = System.Drawing.Color.Transparent;
            this.pnlVeglat.Controls.Add(this.btnKontakt);
            this.pnlVeglat.Controls.Add(this.btnShtoAdmin);
            this.pnlVeglat.Controls.Add(this.btnRrethNesh);
            this.pnlVeglat.Controls.Add(this.pnlGjuhet);
            this.pnlVeglat.Controls.Add(this.lblRegjistro);
            this.pnlVeglat.Controls.Add(this.lblFshij);
            this.pnlVeglat.Controls.Add(this.pbPerdoruesi);
            this.pnlVeglat.Controls.Add(this.lblModifiko);
            this.pnlVeglat.Controls.Add(this.lblEmriUserit);
            this.pnlVeglat.Controls.Add(this.btnFshij);
            this.pnlVeglat.Controls.Add(this.btnModifiko);
            this.pnlVeglat.Controls.Add(this.lblKerko);
            this.pnlVeglat.Controls.Add(this.btnKekro);
            this.pnlVeglat.Controls.Add(this.btnGjuha);
            this.pnlVeglat.Controls.Add(this.btnNdihma);
            this.pnlVeglat.Controls.Add(this.btnRegjistro);
            this.pnlVeglat.Enabled = false;
            this.pnlVeglat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlVeglat.Location = new System.Drawing.Point(243, 35);
            this.pnlVeglat.Name = "pnlVeglat";
            this.pnlVeglat.Size = new System.Drawing.Size(544, 390);
            this.pnlVeglat.TabIndex = 0;
            // 
            // btnKontakt
            // 
            this.btnKontakt.BackColor = System.Drawing.Color.White;
            this.btnKontakt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKontakt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontakt.Font = new System.Drawing.Font("Arial", 12F);
            this.btnKontakt.Image = global::knkV1.Properties.Resources.Mail_icon;
            this.btnKontakt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKontakt.Location = new System.Drawing.Point(364, 310);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(160, 55);
            this.btnKontakt.TabIndex = 7;
            this.btnKontakt.Text = "Kontakto";
            this.btnKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKontakt.UseVisualStyleBackColor = false;
            this.btnKontakt.Visible = false;
            this.btnKontakt.Click += new System.EventHandler(this.btnKontakt_Click);
            // 
            // btnShtoAdmin
            // 
            this.btnShtoAdmin.BackColor = System.Drawing.Color.White;
            this.btnShtoAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShtoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShtoAdmin.Font = new System.Drawing.Font("Arial", 12F);
            this.btnShtoAdmin.Image = global::knkV1.Properties.Resources._1463917704_administrator_add;
            this.btnShtoAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShtoAdmin.Location = new System.Drawing.Point(364, 310);
            this.btnShtoAdmin.Name = "btnShtoAdmin";
            this.btnShtoAdmin.Size = new System.Drawing.Size(160, 55);
            this.btnShtoAdmin.TabIndex = 6;
            this.btnShtoAdmin.Text = "Shto ADM";
            this.btnShtoAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShtoAdmin.UseVisualStyleBackColor = false;
            this.btnShtoAdmin.Visible = false;
            this.btnShtoAdmin.Click += new System.EventHandler(this.btnShtoAdmin_Click);
            // 
            // btnRrethNesh
            // 
            this.btnRrethNesh.BackColor = System.Drawing.Color.White;
            this.btnRrethNesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRrethNesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRrethNesh.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRrethNesh.Image = global::knkV1.Properties.Resources._1463917402_help_forum_lb;
            this.btnRrethNesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRrethNesh.Location = new System.Drawing.Point(364, 233);
            this.btnRrethNesh.Name = "btnRrethNesh";
            this.btnRrethNesh.Size = new System.Drawing.Size(160, 55);
            this.btnRrethNesh.TabIndex = 6;
            this.btnRrethNesh.Text = "Rreth nesh";
            this.btnRrethNesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRrethNesh.UseVisualStyleBackColor = false;
            this.btnRrethNesh.Click += new System.EventHandler(this.btnRrethNesh_Click);
            // 
            // pnlGjuhet
            // 
            this.pnlGjuhet.BackColor = System.Drawing.Color.White;
            this.pnlGjuhet.Controls.Add(this.rbtEn);
            this.pnlGjuhet.Controls.Add(this.rbtShqip);
            this.pnlGjuhet.Location = new System.Drawing.Point(364, 88);
            this.pnlGjuhet.Name = "pnlGjuhet";
            this.pnlGjuhet.Size = new System.Drawing.Size(160, 55);
            this.pnlGjuhet.TabIndex = 4;
            this.pnlGjuhet.Visible = false;
            // 
            // rbtEn
            // 
            this.rbtEn.BackColor = System.Drawing.Color.White;
            this.rbtEn.Image = global::knkV1.Properties.Resources.English;
            this.rbtEn.Location = new System.Drawing.Point(78, 8);
            this.rbtEn.Name = "rbtEn";
            this.rbtEn.Size = new System.Drawing.Size(59, 43);
            this.rbtEn.TabIndex = 1;
            this.rbtEn.TabStop = true;
            this.rbtEn.UseVisualStyleBackColor = false;
            this.rbtEn.CheckedChanged += new System.EventHandler(this.rbtEn_CheckedChanged);
            // 
            // rbtShqip
            // 
            this.rbtShqip.BackColor = System.Drawing.Color.White;
            this.rbtShqip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbtShqip.Checked = true;
            this.rbtShqip.Image = global::knkV1.Properties.Resources.Shqip;
            this.rbtShqip.Location = new System.Drawing.Point(13, 7);
            this.rbtShqip.Name = "rbtShqip";
            this.rbtShqip.Size = new System.Drawing.Size(59, 43);
            this.rbtShqip.TabIndex = 0;
            this.rbtShqip.TabStop = true;
            this.rbtShqip.UseVisualStyleBackColor = false;
            this.rbtShqip.CheckedChanged += new System.EventHandler(this.rbtShqip_CheckedChanged);
            // 
            // lblRegjistro
            // 
            this.lblRegjistro.AutoSize = true;
            this.lblRegjistro.BackColor = System.Drawing.Color.White;
            this.lblRegjistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRegjistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegjistro.Location = new System.Drawing.Point(51, 153);
            this.lblRegjistro.Name = "lblRegjistro";
            this.lblRegjistro.Size = new System.Drawing.Size(70, 18);
            this.lblRegjistro.TabIndex = 7;
            this.lblRegjistro.Text = "Regjistro";
            // 
            // lblFshij
            // 
            this.lblFshij.AutoSize = true;
            this.lblFshij.BackColor = System.Drawing.Color.White;
            this.lblFshij.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFshij.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFshij.Location = new System.Drawing.Point(240, 340);
            this.lblFshij.Name = "lblFshij";
            this.lblFshij.Size = new System.Drawing.Size(41, 18);
            this.lblFshij.TabIndex = 9;
            this.lblFshij.Text = "Fshij";
            // 
            // pbPerdoruesi
            // 
            this.pbPerdoruesi.BackColor = System.Drawing.Color.White;
            this.pbPerdoruesi.BackgroundImage = global::knkV1.Properties.Resources._1463875526_exit;
            this.pbPerdoruesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPerdoruesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPerdoruesi.Location = new System.Drawing.Point(427, 26);
            this.pbPerdoruesi.Name = "pbPerdoruesi";
            this.pbPerdoruesi.Size = new System.Drawing.Size(35, 35);
            this.pbPerdoruesi.TabIndex = 4;
            this.pbPerdoruesi.TabStop = false;
            this.pbPerdoruesi.Click += new System.EventHandler(this.pbPerdoruesi_Click);
            this.pbPerdoruesi.MouseLeave += new System.EventHandler(this.pbPerdoruesi_MouseLeave);
            this.pbPerdoruesi.MouseHover += new System.EventHandler(this.pbPerdoruesi_MouseHover);
            // 
            // lblModifiko
            // 
            this.lblModifiko.AutoSize = true;
            this.lblModifiko.BackColor = System.Drawing.Color.White;
            this.lblModifiko.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblModifiko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiko.Location = new System.Drawing.Point(229, 153);
            this.lblModifiko.Name = "lblModifiko";
            this.lblModifiko.Size = new System.Drawing.Size(68, 18);
            this.lblModifiko.TabIndex = 8;
            this.lblModifiko.Text = "Modifiko";
            // 
            // lblEmriUserit
            // 
            this.lblEmriUserit.AutoSize = true;
            this.lblEmriUserit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmriUserit.Location = new System.Drawing.Point(424, 1);
            this.lblEmriUserit.Name = "lblEmriUserit";
            this.lblEmriUserit.Size = new System.Drawing.Size(52, 22);
            this.lblEmriUserit.TabIndex = 16;
            this.lblEmriUserit.Text = "user";
            this.lblEmriUserit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFshij
            // 
            this.btnFshij.BackColor = System.Drawing.Color.White;
            this.btnFshij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFshij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFshij.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshij.Image = global::knkV1.Properties.Resources.fshij1;
            this.btnFshij.Location = new System.Drawing.Point(186, 215);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(150, 150);
            this.btnFshij.TabIndex = 3;
            this.btnFshij.UseVisualStyleBackColor = false;
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // btnModifiko
            // 
            this.btnModifiko.BackColor = System.Drawing.Color.White;
            this.btnModifiko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifiko.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiko.Image = global::knkV1.Properties.Resources.modifiko__;
            this.btnModifiko.Location = new System.Drawing.Point(186, 26);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(150, 150);
            this.btnModifiko.TabIndex = 1;
            this.btnModifiko.UseVisualStyleBackColor = false;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // lblKerko
            // 
            this.lblKerko.AutoSize = true;
            this.lblKerko.BackColor = System.Drawing.Color.White;
            this.lblKerko.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblKerko.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKerko.Location = new System.Drawing.Point(62, 340);
            this.lblKerko.Name = "lblKerko";
            this.lblKerko.Size = new System.Drawing.Size(50, 18);
            this.lblKerko.TabIndex = 10;
            this.lblKerko.Text = "Kerko";
            // 
            // btnKekro
            // 
            this.btnKekro.BackColor = System.Drawing.Color.White;
            this.btnKekro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKekro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKekro.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKekro.Image = global::knkV1.Properties.Resources.Kerko__;
            this.btnKekro.Location = new System.Drawing.Point(12, 215);
            this.btnKekro.Name = "btnKekro";
            this.btnKekro.Size = new System.Drawing.Size(150, 150);
            this.btnKekro.TabIndex = 2;
            this.btnKekro.UseVisualStyleBackColor = false;
            this.btnKekro.Click += new System.EventHandler(this.btnKekro_Click);
            // 
            // btnGjuha
            // 
            this.btnGjuha.BackColor = System.Drawing.Color.White;
            this.btnGjuha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGjuha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGjuha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGjuha.ForeColor = System.Drawing.Color.Black;
            this.btnGjuha.Image = global::knkV1.Properties.Resources.language1;
            this.btnGjuha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGjuha.Location = new System.Drawing.Point(364, 88);
            this.btnGjuha.Name = "btnGjuha";
            this.btnGjuha.Size = new System.Drawing.Size(160, 55);
            this.btnGjuha.TabIndex = 23;
            this.btnGjuha.Text = "Gjuha";
            this.btnGjuha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGjuha.UseVisualStyleBackColor = false;
            this.btnGjuha.Click += new System.EventHandler(this.btnGjuha_Click);
            // 
            // btnNdihma
            // 
            this.btnNdihma.BackColor = System.Drawing.Color.White;
            this.btnNdihma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNdihma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNdihma.Font = new System.Drawing.Font("Arial", 12F);
            this.btnNdihma.Image = global::knkV1.Properties.Resources._1463917220_help_browser;
            this.btnNdihma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNdihma.Location = new System.Drawing.Point(364, 166);
            this.btnNdihma.Name = "btnNdihma";
            this.btnNdihma.Size = new System.Drawing.Size(160, 55);
            this.btnNdihma.TabIndex = 5;
            this.btnNdihma.Text = "Ndihma";
            this.btnNdihma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNdihma.UseVisualStyleBackColor = false;
            this.btnNdihma.Click += new System.EventHandler(this.btnNdihma_Click);
            // 
            // btnRegjistro
            // 
            this.btnRegjistro.BackColor = System.Drawing.Color.White;
            this.btnRegjistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegjistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegjistro.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegjistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegjistro.Image")));
            this.btnRegjistro.Location = new System.Drawing.Point(12, 26);
            this.btnRegjistro.Name = "btnRegjistro";
            this.btnRegjistro.Size = new System.Drawing.Size(150, 150);
            this.btnRegjistro.TabIndex = 0;
            this.btnRegjistro.UseVisualStyleBackColor = false;
            this.btnRegjistro.Click += new System.EventHandler(this.btnRegjistro_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdOpsione,
            this.tstGjuha,
            this.tstNdihma});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(592, 25);
            this.menu.TabIndex = 96;
            this.menu.Text = "Menu";
            // 
            // tsdOpsione
            // 
            this.tsdOpsione.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMbyll});
            this.tsdOpsione.Image = ((System.Drawing.Image)(resources.GetObject("tsdOpsione.Image")));
            this.tsdOpsione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsdOpsione.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdOpsione.Name = "tsdOpsione";
            this.tsdOpsione.Size = new System.Drawing.Size(80, 22);
            this.tsdOpsione.Text = "Opsione";
            // 
            // tlsMbyll
            // 
            this.tlsMbyll.Image = ((System.Drawing.Image)(resources.GetObject("tlsMbyll.Image")));
            this.tlsMbyll.Name = "tlsMbyll";
            this.tlsMbyll.Size = new System.Drawing.Size(104, 22);
            this.tlsMbyll.Text = "Mbyll";
            this.tlsMbyll.Click += new System.EventHandler(this.tsdmbyll_Click);
            // 
            // tstGjuha
            // 
            this.tstGjuha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstShqip,
            this.tstAnglisht});
            this.tstGjuha.Image = global::knkV1.Properties.Resources.language;
            this.tstGjuha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstGjuha.Name = "tstGjuha";
            this.tstGjuha.Size = new System.Drawing.Size(67, 22);
            this.tstGjuha.Text = "Gjuha";
            // 
            // tstShqip
            // 
            this.tstShqip.Image = global::knkV1.Properties.Resources.Shqip;
            this.tstShqip.Name = "tstShqip";
            this.tstShqip.Size = new System.Drawing.Size(118, 22);
            this.tstShqip.Text = "Shqip";
            this.tstShqip.Click += new System.EventHandler(this.rbtShqip_CheckedChanged);
            // 
            // tstAnglisht
            // 
            this.tstAnglisht.Image = global::knkV1.Properties.Resources.English;
            this.tstAnglisht.Name = "tstAnglisht";
            this.tstAnglisht.Size = new System.Drawing.Size(118, 22);
            this.tstAnglisht.Text = "Anglisht";
            this.tstAnglisht.Click += new System.EventHandler(this.rbtEn_CheckedChanged);
            // 
            // tstNdihma
            // 
            this.tstNdihma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstNdihma_Ndihma,
            this.tstNdihma_Kontakto,
            this.tstNdihma_Rrethnesh});
            this.tstNdihma.Image = global::knkV1.Properties.Resources.Aroche_Delta_Help;
            this.tstNdihma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tstNdihma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstNdihma.Name = "tstNdihma";
            this.tstNdihma.Size = new System.Drawing.Size(79, 22);
            this.tstNdihma.Text = "Ndihma";
            // 
            // tstNdihma_Ndihma
            // 
            this.tstNdihma_Ndihma.Image = global::knkV1.Properties.Resources.help1;
            this.tstNdihma_Ndihma.Name = "tstNdihma_Ndihma";
            this.tstNdihma_Ndihma.Size = new System.Drawing.Size(132, 22);
            this.tstNdihma_Ndihma.Text = "Ndihma";
            this.tstNdihma_Ndihma.Click += new System.EventHandler(this.btnNdihma_Click);
            // 
            // tstNdihma_Kontakto
            // 
            this.tstNdihma_Kontakto.Image = global::knkV1.Properties.Resources.Mail_icon;
            this.tstNdihma_Kontakto.Name = "tstNdihma_Kontakto";
            this.tstNdihma_Kontakto.Size = new System.Drawing.Size(132, 22);
            this.tstNdihma_Kontakto.Text = "Kontakto";
            this.tstNdihma_Kontakto.Click += new System.EventHandler(this.btnKontakt_Click);
            // 
            // tstNdihma_Rrethnesh
            // 
            this.tstNdihma_Rrethnesh.Image = global::knkV1.Properties.Resources._1463917402_help_forum_lb;
            this.tstNdihma_Rrethnesh.Name = "tstNdihma_Rrethnesh";
            this.tstNdihma_Rrethnesh.Size = new System.Drawing.Size(132, 22);
            this.tstNdihma_Rrethnesh.Text = "Rreth Nesh";
            this.tstNdihma_Rrethnesh.Click += new System.EventHandler(this.btnRrethNesh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstKohaAktuale,
            this.tstKoha,
            this.tstStatistika});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(592, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 97;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstKohaAktuale
            // 
            this.tstKohaAktuale.BackColor = System.Drawing.SystemColors.Control;
            this.tstKohaAktuale.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstKohaAktuale.Name = "tstKohaAktuale";
            this.tstKohaAktuale.Size = new System.Drawing.Size(84, 17);
            this.tstKohaAktuale.Text = "Koha aktuale: ";
            // 
            // tstKoha
            // 
            this.tstKoha.BackColor = System.Drawing.SystemColors.Control;
            this.tstKoha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstKoha.Name = "tstKoha";
            this.tstKoha.Size = new System.Drawing.Size(55, 17);
            this.tstKoha.Text = ". . : . . : . .";
            // 
            // tstStatistika
            // 
            this.tstStatistika.BackColor = System.Drawing.SystemColors.Control;
            this.tstStatistika.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstStatistika.IsLink = true;
            this.tstStatistika.Name = "tstStatistika";
            this.tstStatistika.Size = new System.Drawing.Size(58, 17);
            this.tstStatistika.Text = "Statistika";
            this.tstStatistika.Visible = false;
            this.tstStatistika.Click += new System.EventHandler(this.tstStatistika_Click);
            // 
            // tmrOra
            // 
            this.tmrOra.Enabled = true;
            this.tmrOra.Interval = 1000;
            this.tmrOra.Tick += new System.EventHandler(this.tmrOra_Tick);
            // 
            // tmrKohaEMbylljes
            // 
            this.tmrKohaEMbylljes.Interval = 20;
            this.tmrKohaEMbylljes.Tick += new System.EventHandler(this.tmrKohaEMbylljes_Tick);
            // 
            // frmMenaxhoAdresat
            // 
            this.AcceptButton = this.btnLog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(592, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnlVeglat);
            this.Controls.Add(this.pnlLogimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMenaxhoAdresat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemi Per Menaxhimin E Adresave";
            this.Load += new System.EventHandler(this.frmMenaxhoAdresat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenaxhoAdresat_KeyDown);
            this.pnlLogimi.ResumeLayout(false);
            this.pnlLogimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFjalekalimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerdoruesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlVeglat.ResumeLayout(false);
            this.pnlVeglat.PerformLayout();
            this.pnlGjuhet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerdoruesi)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlLogimi;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Timer tmrKohaShfaqjes;
        private System.Windows.Forms.Panel pnlVeglat;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripDropDownButton tsdOpsione;
        private System.Windows.Forms.ToolStripMenuItem tlsMbyll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstKohaAktuale;
        private System.Windows.Forms.ToolStripStatusLabel tstKoha;
        private System.Windows.Forms.Timer tmrOra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbPerdoruesi;
        private System.Windows.Forms.Label lblKerko;
        private System.Windows.Forms.Label lblFshij;
        private System.Windows.Forms.Label lblModifiko;
        private System.Windows.Forms.Label lblRegjistro;
        private System.Windows.Forms.Label lblEmriUserit;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Button btnKekro;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnGjuha;
        private System.Windows.Forms.Button btnNdihma;
        private System.Windows.Forms.Button btnRegjistro;
        private System.Windows.Forms.RadioButton rbtEn;
        private System.Windows.Forms.RadioButton rbtShqip;
        private System.Windows.Forms.Timer tmrKohaEMbylljes;
        private System.Windows.Forms.Panel pnlGjuhet;
        private System.Windows.Forms.PictureBox pcbFjalekalimi;
        private System.Windows.Forms.PictureBox pcbPerdoruesi;
        private System.Windows.Forms.LinkLabel llRegjistrohu;
        private System.Windows.Forms.ToolStripDropDownButton tstGjuha;
        private System.Windows.Forms.ToolStripMenuItem tstShqip;
        private System.Windows.Forms.ToolStripMenuItem tstAnglisht;
        private System.Windows.Forms.Button btnShtoAdmin;
        private System.Windows.Forms.Button btnRrethNesh;
        private System.Windows.Forms.Button btnKontakt;
        private System.Windows.Forms.ToolStripDropDownButton tstNdihma;
        private System.Windows.Forms.ToolStripMenuItem tstNdihma_Ndihma;
        private System.Windows.Forms.ToolStripMenuItem tstNdihma_Kontakto;
        private System.Windows.Forms.ToolStripMenuItem tstNdihma_Rrethnesh;
        private System.Windows.Forms.ToolStripStatusLabel tstStatistika;
    }
}

