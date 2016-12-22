using System;
using System.Collections.Generic; //per me kriju koleksione
using System.ComponentModel; //runtime edhe design time te komponenteve
using System.Data; //manipulimi i data te dhenava
using System.Drawing; //ofron interface per grafike
using System.Linq; //ofron interface per query - LANGUAGE INTEGRATED QUERY
using System.Text; //oferon ASCII dhe UNICODE interface
using System.Threading.Tasks; //ofron tipe per thjeshtim te punes me threads
using System.Windows.Forms; //per forma
using System.Net.Mail; //network mail
using System.Threading; //ofron interface te multithreading

using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo

namespace knkV1 
{
    public partial class Dergo_Email : Form
    {
        public Dergo_Email() //konstruktore sherben si inicializues fillestar
        {
            InitializeComponent();         
           
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            tsdndryshoPrapavijen.Text = rm.GetString("tsdndryshoPrapavijen", ci);
            tstInfo.Text = rm.GetString("tstInfo", ci);
            lblInfo.Text = rm.GetString("lblInfopersonale", ci);
            label1.Text = rm.GetString("Nga", ci);
            label3.Text = rm.GetString("Subjekt", ci);
            tsdOpsione.Text = rm.GetString("tsdOpsione", ci);
            label5.Text = rm.GetString("Bashko", ci);
            tsdmbyll.Text = rm.GetString("tlsMbyll", ci);
            btnShtegu.Text = rm.GetString("Shtegu", ci);
            toolStripStatusLabel1.Text = rm.GetString("tstKohaAktuale", ci);
            label4.Text = rm.GetString("Mesazhi", ci);
            btnAnulo.Text = rm.GetString("Anulo", ci);
            this.Text = "Send Mail";
        }
        
        string pass = "";                       //me perdore kete pass
        public Dergo_Email(string e, string p)
        {
            InitializeComponent();
            txtNga.Text = e;                    //le te barazohet me imell
            pass = p;                           //le te barazohet me password

            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
            }
        }


        private void pbDergo_Click(object sender, EventArgs e)              //nese shtypet pictureboxi per dergim
        {
            for (int i = 0; i < 10; i++)            
                tstProgresi.Value += 10;         
           
            fnDergimi();                                                    //thirret funk. i dergimit te email
        }

        private void btnShtegu_Click(object sender, EventArgs e)            //nese perdoruesi zgjedh attachment
        {
            OpenFileDialog opfd = new OpenFileDialog();                     //openfile dialog per te zgjedhur file
            // opfd.Multiselect = true;

            if (opfd.ShowDialog() == DialogResult.OK)                       //kur perdoruesi shtyp ok per file
            {
                txtShtegu.Text = opfd.FileName;                             //shtegu merr vleren e shtegut te fajllit
                //string[] arrAllFiles = opfd.FileNames; //used when Multiselect = true           
            }
        }

        private void pbDergo_MouseHover(object sender, EventArgs e)
        {
            pbDergo.BorderStyle = BorderStyle.Fixed3D;                      //per efektin 3D
        }

        private void pbDergo_MouseLeave(object sender, EventArgs e)         //nese largohet nga pictureboxi
        {
            pbDergo.BorderStyle = BorderStyle.FixedSingle;                  //kthehet borderstyle si ne fillim
        }

        private void fnDergimi()                                            //funksioni per dergimin e email
        {
            try
            {
                MailMessage mail = new MailMessage();                       //obj mail
                SmtpClient Smtp = new SmtpClient("smtp.live.com");          //protokoll i email
                mail.From = new MailAddress(txtNga.Text);                   //nga kush do te dergohet
                        
             //2.The Destination email Addresses
                MailAddressCollection ListaEAdresave = new MailAddressCollection();         //per me shume email adresa
                //dergohet te ADMINat
                ListaEAdresave.Add("arti._3@hotmail.com");
                ListaEAdresave.Add("armendd.u@hotmail.com");
                ListaEAdresave.Add("malkurteshi@gmail.com");
                 ListaEAdresave.Add("gtkrasniqi@gmail.com");
                 ListaEAdresave.Add("azem.ahmexhekaj1@gmail.com");
                mail.To.Add(ListaEAdresave.ToString());                                   ///me dergu ne shume adresa
                
                if (txtShtegu.Text != "")                                                   //nese ka attachment                     
                {
                    System.Net.Mail.Attachment attachment;                                  //dergo attachment
                    attachment = new System.Net.Mail.Attachment(txtShtegu.Text);            //attachment gjendet ne baze te shtegut te zgjedhur
                    mail.Attachments.Add(attachment);                                       //ne mail shto attachmentin e zgjedhur
                }
                Smtp.Port = 587;                                                            //smtp perdori qe perdoret per dergimin e email addresave
                Smtp.Credentials = new System.Net.NetworkCredential(txtNga.Text, pass);     //credidencilat qe i duhen applikacionit per te derguar email, email dhe passi i asaj emaile
                Smtp.EnableSsl = true;  //secure socket layer perdoret per te autentikuar serverin , nese mundet edhe klientin
                
                if (String.IsNullOrEmpty(txtBody.Text)) //nese nuk ka shkruar addrese                
                    MessageBox.Show("Ju lutem mbushni fushat.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                else
                {
                    Smtp.Send(mail);                                                        //perndryshe dergo ate email
                    
                    MessageBox.Show("Email-i u dergua!", "Njoftim", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);                    
                    txtBody.ResetText();
                    txtShtegu.ResetText();
                    txtSubject.ResetText();                                                 //i pastron textboxat                    
                }
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ka ndodhur gabimi me email ose me password. \n\n" + ex, "Gabim!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tstProgresi.Value = 0;                                                          //vlera e progresbarit
        }

        

        private void txtBody_KeyDown(object sender, KeyEventArgs e) //mundesia e dergimit me tastin Shift+Enter
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift)  fnDergimi(); 
        }

        private void tmrKoha_Tick(object sender, EventArgs e)       //timeri per kohen momentale
        {
            tstKoha.Text = DateTime.Now.ToString("HH:mm:ss ");
        }

        private void tsdmbyll_Click(object sender, EventArgs e)     //per mbyllje te applikacionit
        {
            this.Close();
        }

        private void mundesia1_Click(object sender, EventArgs e)    //nese deshiron te ndrroje ngjyren perdoruesi
        {
            pnl0.BackColor = Color.PowderBlue;
            pnl1.BackColor = Color.PowderBlue;
            pnl2.BackColor = Color.PowderBlue;
            pnl3.BackColor = Color.PowderBlue;
            pnl4.BackColor = Color.PowderBlue;
        }

        private void mundesia2_Click(object sender, EventArgs e)
        {
            pnl0.BackColor = Color.Snow;
            pnl1.BackColor = Color.Snow;
            pnl2.BackColor = Color.Snow;
            pnl3.BackColor = Color.Snow;
            pnl4.BackColor = Color.Snow;
        }

        private void mundesia3_Click(object sender, EventArgs e)
        {
            pnl0.BackColor = Color.PaleGreen;
            pnl1.BackColor = Color.PaleGreen;
            pnl2.BackColor = Color.PaleGreen;
            pnl3.BackColor = Color.PaleGreen;
            pnl4.BackColor = Color.PaleGreen;
        }

        private void mundesia4_Click(object sender, EventArgs e)
        {
            pnl0.BackColor = Color.Thistle;
            pnl1.BackColor = Color.Thistle;
            pnl2.BackColor = Color.Thistle;
            pnl3.BackColor = Color.Thistle;
            pnl4.BackColor = Color.Thistle;
        }

        private void tstInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void tstInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void txtCelesi_KeyPress(object sender, KeyPressEventArgs e)     //celesi nuk pranon shkronja
        {
            //karakteret qe nuk jane numra kane kodin:
            // <48 dhe >57
            //backspace = 8
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtKu_Enter(object sender, EventArgs e)                    //nese hyn perdoruesi ne textboxin KU
        {
            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox
            int VisibleTime = 2000;  //ne millisekonda

            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show("Perdor ';' per te ndare 2 ose me shume e-mail adresa", tb,290, 5, VisibleTime);    //shfaqet ky mesazh
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}
 