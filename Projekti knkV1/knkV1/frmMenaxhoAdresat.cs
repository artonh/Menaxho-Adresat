using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo
using System.Security.Cryptography;

namespace knkV1
{
    public partial class frmMenaxhoAdresat : Form
    {
        public frmMenaxhoAdresat()
        {
            InitializeComponent();
            Parametrat._Gjuha = "Shqip";
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            btnLog.Text = rm.GetString("btnLog", ci);
            lblRegjistro.Text = rm.GetString("lblRegjistro", ci);
            lblModifiko.Text = rm.GetString("lblModifiko", ci);
            lblKerko.Text = rm.GetString("lblKerko", ci);
            lblFshij.Text = rm.GetString("lblFshij", ci);
            tstKohaAktuale.Text = rm.GetString("tstKohaAktuale", ci);
            tsdOpsione.Text = rm.GetString("tsdOpsione", ci);
            tstGjuha.Text = rm.GetString("tstGjuha", ci);
            tlsMbyll.Text = rm.GetString("tlsMbyll", ci);
            tstShqip.Text = rm.GetString("tstShqip", ci);
            tstAnglisht.Text = rm.GetString("tstAnglisht", ci);
            btnGjuha.Text = rm.GetString("btnGjuha", ci);
            btnNdihma.Text = rm.GetString("btnNdihma", ci);
            btnRrethNesh.Text = rm.GetString("btnRrethNesh", ci);
            btnKontakt.Text = rm.GetString("btnKontakt", ci);
            btnShtoAdmin.Text = rm.GetString("btnShtoAdmin", ci);
            llRegjistrohu.Text = rm.GetString("llRegjistrohu", ci);
            tstNdihma.Text = rm.GetString("tstNdihma", ci);
            tstNdihma_Kontakto.Text = rm.GetString("tstNdihma_Kontakto", ci);
            tstNdihma_Ndihma.Text = rm.GetString("tstNdihma_Ndihma", ci);
            tstNdihma_Rrethnesh.Text = rm.GetString("tstNdihma_Rrethnesh", ci);
            tstStatistika.Text = rm.GetString("tstStatistika", ci);
            this.Text = rm.GetString("frmMenaxhoAdresat", ci);
        }          

        int vlera = 0, vlera2 = 0;      //var. ndihmese 
        private void btnLOG_Click(object sender, EventArgs e)
        {
            LidhjaMeDB objDB = new LidhjaMeDB();

            string username = txtUser.Text;
            string password = txtPass.Text;
            
            DataSet _ds = objDB.LexoShenimet("SELECT * FROM tblPerdoruesi WHERE username='" +
                username + "'");
            if (objDB.MesazhGabimi == "")
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {    
                    string salt = _ds.Tables[0].Rows[0]["Salt"].ToString();
                    string saltedHashLogin = LLogariteSaltHash(salt, password);
                    string saltedHashNgaDatabaza = _ds.Tables[0].Rows[0]["Password"].ToString();


                    if (saltedHashLogin.Equals(saltedHashNgaDatabaza))
                    {
                        Parametrat._username = _ds.Tables[0].Rows[0]["username"].ToString();
                        Parametrat._GrupiID = int.Parse(_ds.Tables[0].Rows[0]["GrupiID"].ToString());
                        Parametrat._EmriMbiemri = _ds.Tables[0].Rows[0]["Emri"].ToString();

                        lblEmriUserit.Text = Parametrat._username;
                        tmrKohaShfaqjes.Enabled = true;
                        tmrKohaShfaqjes.Start();
                        pnlVeglat.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fajlekalimi eshte gabim!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Clear();
                    }                   
                }
                else { MessageBox.Show("Ky perdorues nuk ekziston!"); txtPass.Clear(); txtUser.Clear(); }
            }
            else
            {
                MessageBox.Show(objDB.MesazhGabimi);
            }
            if (Parametrat._GrupiID == 1)   //nese eshte admin
            {
                btnShtoAdmin.Visible = true;            //i shtohet mundesia per Shtim te adminnit
                btnKontakt.Visible = false;
                tstStatistika.Visible = true;           //dhe per statistika
            }
            else
            {
                btnKontakt.Visible = true;
                btnShtoAdmin.Visible = false;
            }
        }

        private string LLogariteSaltHash(string salt, string password)
        {
            string saltPass = salt + password;
            byte[] bajtSaltPass = Encoding.UTF8.GetBytes(saltPass);

            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();
            byte[] bajtHashVlera = objHash.ComputeHash(bajtSaltPass);

            return Convert.ToBase64String(bajtHashVlera);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics obj = e.Graphics;
            if (vlera != 0 && tmrKohaShfaqjes.Enabled == true)
            {
                pnlVeglat.Location = new Point(vlera, pnlLogimi.Location.Y);
                tmrKohaEMbylljes.Enabled = false;  //qe edhe ky me nal kete tjterin
            }
            if (vlera2 != 0 && tmrKohaEMbylljes.Enabled == true)
            {
                pnlVeglat.Location = new Point(vlera2, pnlLogimi.Location.Y);
                tmrKohaShfaqjes.Enabled = false;
            }
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
           new Point(0, 200),
           new Point(0, 500),
           Color.FromArgb(255, 245, 252, 255),//LEHTE
           Color.FromArgb(255, 168, 226, 255)); //FORTE

            Pen pen = new Pen(linGrBrush);

            e.Graphics.FillRectangle(linGrBrush, 0, 210, 600, 300);
        }

     
        private void tmrOra_Tick(object sender, EventArgs e)//shfaqe kohen aktuale
        {
            tstKoha.Text = DateTime.Now.ToString("HH:mm:ss ");
        }

        private void tsdmbyll_Click(object sender, EventArgs e)//tsd per mbyllje te formes
        {
            this.Close();
        }

        private void btnGjuha_Click(object sender, EventArgs e)//shfaqen rbt e gjuheve perkatese
        {
            pnlGjuhet.Visible = true;
           /// btnGjuha.Image = None;  edhe me u hjek fotoja mbrapa
            btnGjuha.BackgroundImage = null;
         
        }

        private void rbtShqip_CheckedChanged(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("al-AL");
            NdrroGjuhen(ci, "knkV1.Lang.langres.al");
            Parametrat._Gjuha = "Shqip";
       
        }

        private void rbtEn_CheckedChanged(object sender, EventArgs e)//per gjuhen Angleze
        {
            pnlGjuhet.Visible = false;

            CultureInfo ci = new CultureInfo("en-US");
            NdrroGjuhen(ci, "knkV1.Lang.langres");
            Parametrat._Gjuha = "Anglisht";
        }

        private void pbPerdoruesi_Click(object sender, EventArgs e)
        {            
            tmrKohaEMbylljes.Enabled = true;
            txtUser.Clear();
            txtPass.Clear();
            tmrKohaEMbylljes.Start();
            Parametrat._username = "";
            Parametrat._EmriMbiemri = "";
            tstStatistika.Visible = false;
        }

        private void tmrKohaShfaqjes_Tick(object sender, EventArgs e)//per shfaqjen e veglave
        {
            pnlLogimi.Visible = false;
            int x = pnlLogimi.Location.X;        //pnl i logimit
            int x1 = pnlVeglat.Location.X;        //pnl i logimit
            if (x1 >= x + 12)  //nese paneli i veglave eshte >= pnl i logimit +20            
                x1 -= 20;     //zbrite distancen e pnl logimit            
            else
                tmrKohaShfaqjes.Enabled = false;
            vlera = x1;
            this.Invalidate();
        }
        private void tmrKohaEMbylljes_Tick(object sender, EventArgs e)//per mbylljen e veglave, shfaqjen e logimit
        {

            int y = pnlLogimi.Location.X; //pnl i logimit
            if (y <= 230 && vlera2 <= 230)//243 eshte distanca ku duhet te ndalet            
                vlera2 += 20;  
            else
            {
                tmrKohaEMbylljes.Enabled = false;
                pnlLogimi.Visible = true;
                pnlVeglat.Enabled = false;
                //cboPerdoruesi.Visible = false;
                vlera2 = 0; //qe me startu levizjen aq here sa klikon butonin Logohu
            }
            this.Invalidate();
        }

        private void btnNdihma_Click(object sender, EventArgs e)
        {
            frmNdihma frm = new frmNdihma();
            frm.Show();        
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
           frmRegjistroAdresa frmR = new frmRegjistroAdresa();
           frmR.Show();
        }

        private void btnKekro_Click(object sender, EventArgs e)
        {
            frmKerko frmK = new frmKerko();
            frmK.Show();
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            if (Parametrat._GrupiID != 1)
            {
                MessageBox.Show("Nuk keni akses!", "Njoftim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmFshij frmF = new frmFshij();
                frmF.Show();
            }
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            frmModifiko frmM = new frmModifiko();
            frmM.Show();
        }

        private void llRegjistrohu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegjistroPerdorues frm = new frmRegjistroPerdorues();
            frm.ShowDialog(this);
        }

        private void btnRrethNesh_Click(object sender, EventArgs e)
        {
            frmRrethNesh frm = new frmRrethNesh();
            frm.Show();

        }

        private void btnShtoAdmin_Click(object sender, EventArgs e)
        {
            frmShtoAdmin frm = new frmShtoAdmin();
            frm.Show();
        }

       
        private void frmMenaxhoAdresat_Load(object sender, EventArgs e)
        {
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            //karakteret qe nuk jane shkronja kane kodin: < 65 ||  > 90 
            //karakteret qe nuk jane numra kane kodin: <48 dhe >57
            //space 32  //backspace = 8   //DEL=127
            //@ = 64   //- = 45  //, =44    //.=46  //_=95 
            if (((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 96 || e.KeyChar > 122))
                            && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) &&
                            e.KeyChar != 32 && e.KeyChar != 64 && e.KeyChar != 45 && e.KeyChar != 44
                            && e.KeyChar != 46 && e.KeyChar != 95 && e.KeyChar != 127)
                e.Handled = true;
            
               
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //karakteret qe nuk jane shkronja kane kodin: < 65 ||  > 90 
            //karakteret qe nuk jane numra kane kodin: <48 dhe >57
            //space 32  //backspace = 8   //DEL=127
            //@ = 64   //- = 45  //, =44    //.=46  //_=95 
            if (((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 96 || e.KeyChar > 122))
                            && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) &&
                            e.KeyChar != 32 && e.KeyChar != 64 && e.KeyChar != 45 && e.KeyChar != 44
                            && e.KeyChar != 46 && e.KeyChar != 95 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void pbPerdoruesi_MouseHover(object sender, EventArgs e)
        {
            pbPerdoruesi.BackgroundImage = knkV1.Properties.Resources._1463875519_shutdown;
            
        }

        private void pbPerdoruesi_MouseLeave(object sender, EventArgs e)
        {
            pbPerdoruesi.BackgroundImage = knkV1.Properties.Resources._1463875526_exit;
        }

        private void btnKontakt_Click(object sender, EventArgs e)
        {
            Kycja frm = new Kycja();  //kjo eshte frmKontakt ,,, e riemruar
            frm.Show();  //
        }

        private void tstStatistika_Click(object sender, EventArgs e)
        {
            frmStatistika frm = new frmStatistika();
            frm.Show();
        }

        private void frmMenaxhoAdresat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)   //ndihma shfaqet per cdo perdorues
            { frmNdihma objNdihma = new frmNdihma(); objNdihma.Show(); }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                frmRegjistroPerdorues objPerd = new frmRegjistroPerdorues(); objPerd.Show();
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                if (Parametrat._Gjuha == "Shqip")
                {
                    CultureInfo ci = new CultureInfo("al-AL");
                    NdrroGjuhen(ci, "knkV1.Lang.langres");
                    Parametrat._Gjuha = "Anglisht";
                }
                else if (Parametrat._Gjuha == "Anglisht")
                {
                    CultureInfo ci = new CultureInfo("al-AL");
                    NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                    Parametrat._Gjuha = "Shqip";
                }
            }

            if (pnlVeglat.Enabled == true)
            {
                if (e.Control && e.KeyCode == Keys.F)
                {
                    frmKerko objKerko = new frmKerko();
                    objKerko.Show();
                }
                else if (e.Control && e.KeyCode == Keys.R)
                {
                    frmRegjistroAdresa objRA = new frmRegjistroAdresa(); objRA.Show();
                }
                else if (e.Control && e.KeyCode == Keys.M)
                {
                    frmModifiko objMod = new frmModifiko(); objMod.Show();
                }
                else if (Parametrat._GrupiID==1 && e.Control && e.KeyCode == Keys.D) //vetem ADMINat mund te bejne kete
                {
                    frmFshij objFs = new frmFshij(); objFs.Show();
                }
                else if (Parametrat._GrupiID == 1 && e.Control && e.KeyCode == Keys.A) //vetem ADMINat mund te bejne kete
                {
                    frmShtoAdmin objshtoadm = new frmShtoAdmin(); objshtoadm.Show();
                }
                else if (e.Control && e.KeyCode == Keys.E)
                {
                    Kycja objKyc = new Kycja(); objKyc.Show();
                }
                else if (e.Control && e.KeyCode == Keys.I)
                {
                    frmRrethNesh objRreth = new frmRrethNesh(); objRreth.Show();
                }
                else if (e.Control && e.KeyCode == Keys.F4)
                {
                    tmrKohaEMbylljes.Enabled = true;
                    txtUser.Clear();
                    txtPass.Clear();
                    tmrKohaEMbylljes.Start();
                }
            }


        }

        string ndihma = "";
        int VisibleTime = 2000;  //ne millisekonda
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your Username";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj Username-in tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox  
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtUser.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your Password";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj Fjalekalimin-in tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtPass.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }



 


       

        


        


     


    }
}
