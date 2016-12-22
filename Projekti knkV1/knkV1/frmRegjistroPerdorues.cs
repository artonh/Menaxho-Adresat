using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; //network mail
using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo
using System.Security.Cryptography;

namespace knkV1
{
    public partial class frmRegjistroPerdorues : Form
    {
        LidhjaMeDB objDB = new LidhjaMeDB();
        public frmRegjistroPerdorues()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Register user";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Regjistro perdorues";
            }
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            lblUsername.Text = rm.GetString("user", ci) + ":";
            lblPassword.Text = rm.GetString("pass", ci) + ":";
            lblEmri.Text = rm.GetString("Emri", ci) + ":";
            lblMbiemri.Text = rm.GetString("Mbiemri", ci) + ":";
            lblGjinia.Text = rm.GetString("Gjinia", ci) + ":";
            rbtMashkull.Text = rm.GetString("Mashkull", ci);
            rbtFemer.Text = rm.GetString("Femer", ci);
            label1.Text = rm.GetString("Datelindja", ci) + ":";
            btnKonfirmo.Text = rm.GetString("Konfirmo", ci);
            btnReset.Text = rm.GetString("Pastro", ci);
        }   

        private void btnKonfirmo_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmri.Text == "" || txtFjalekalimi.Text == ""
                || txtMbiemri.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Ju lutemi, mbusheni formen!", "Njoftim");
            else
            {
                try
                {
                    string username, emri, salt, saltedHashPWD;
                    username = txtUsername.Text;
                    emri = txtEmri.Text;
                    salt = new Random(DateTime.Now.Millisecond).Next(10000, 1000000).ToString();
                    saltedHashPWD = LLogariteSaltHash(salt, txtFjalekalimi.Text); //behete saltHASH
                                        
                    var test = new MailAddress(txtEmail.Text);
                    string _Query = "";
                    string Gjinia = "";
                    if (rbtMashkull.Checked) Gjinia = "M"; else Gjinia = "F";
                    _Query = "Insert Into tblPerdoruesi (" +
                    "username, Password, Emri, Mbiemri, Gjinia, Ditelindja" +
                    ", Email, DataRegjistrimit, GrupiID, Salt) VALUES ('" +
                    username + "','" +
                    saltedHashPWD + "','" +
                    emri + "','" + txtMbiemri.Text + "','" +
                    Gjinia + "','" + dtpDatelindja.Text + "','" +
                    txtEmail.Text + "',GetDate()" + ",2,'"+salt+"')";

                    string _Mesazhi = objDB.InsUpdDel(_Query);
                    if (_Mesazhi == "")
                    {
                        _Mesazhi = "Jeni regjistruar me sukses";
                        this.Pastro();
                        this.Close();
                    }
                    MessageBox.Show(_Mesazhi);
                }
                catch (FormatException) { MessageBox.Show("Shkruani nje email valide"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
               
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

        private void Pastro()
        {
            txtUsername.Clear();
            txtFjalekalimi.Clear();
            txtEmri.Clear();
            txtMbiemri.Clear();
            dtpDatelindja.Value = DateTime.Now;
            txtEmail.Clear();
            rbtMashkull.Checked = true;

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja, numra dhe pika");
        }

        private void txtFjalekalimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja, numra dhe pika");
        }

        private void txtEmri_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void txtMbiemri_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja, numra dhe pika");
        }

        private void ValidimFushash(object sender, KeyPressEventArgs e, string mundesia)
        {
            switch (mundesia)
            {
                case "shkronja":
                    //karakteret qe nuk jane shkronja kane kodin: < 65 ||  > 90  //space=32  //backspace = 8   //DEL=127                    
                    if (((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 96 || e.KeyChar > 122))
                                    && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 127)
                        e.Handled = true;
                    break;

                case "shkronja, numra dhe pika":
                    //karakteret qe nuk jane shkronja kane kodin: < 65 ||  > 90 
                    //karakteret qe nuk jane numra kane kodin: <48 dhe >57
                    //space 32  //backspace = 8   //DEL=127
                    //@ = 64   //- = 45  //, =44    //.=46  //_=95 
                    if (((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 96 || e.KeyChar > 122))
                                    && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) &&
                                    e.KeyChar != 32 && e.KeyChar != 64 && e.KeyChar != 45 && e.KeyChar != 44
                                    && e.KeyChar != 46 && e.KeyChar != 95 && e.KeyChar != 127)
                        e.Handled = true;
                    break;
            }

        }  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Pastro();
        }

        string ndihma = "";
        int VisibleTime = 2000;  //ne millisekonda
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your Username";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj Username-in tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtUsername.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }

        private void txtFjalekalimi_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your Password";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj Fjalekalimin tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtFjalekalimi.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }

        private void txtEmri_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your Name";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj Emrin tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtFjalekalimi.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }

        private void txtMbiemri_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your Surname";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj Mbiemrin tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtFjalekalimi.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                ndihma = "Write your e-Mail";
            else if (Parametrat._Gjuha == "Shqip")
                ndihma = "Shkruaj e-Mailin tuaj";

            TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
            ToolTip tt = new ToolTip();                                         //tooltip
            tt.Show(ndihma, tb, txtFjalekalimi.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
        }

    }
}
