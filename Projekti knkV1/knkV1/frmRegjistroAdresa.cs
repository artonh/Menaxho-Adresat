using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo

namespace knkV1
{
    public partial class frmRegjistroAdresa : Form
    {
        LidhjaMeDB objDB = new LidhjaMeDB();
        int _IDaddr = 0;
        public frmRegjistroAdresa()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Register place";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Regjistro vende";
            }
        }
        public frmRegjistroAdresa(int IDaddr, string Komuna, string Vendi,string Rruga, int NrV, string Shteti, string Sqarime, float Latitude,  float Longitude)
        {
            InitializeComponent();
            _IDaddr = IDaddr;
            cboKomuna.Text = Komuna;
            txtVendi.Text = Vendi;
            txtRruga.Text = Rruga;
            txtNrVendbanimit.Text = NrV.ToString();
            txtShteti.Text = Shteti;
            txtSqarime.Text = Sqarime;
            txtLatitude.Text = Latitude.ToString();
            txtLongitude.Text = Longitude.ToString();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Register place";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Regjistro vende";
            }
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            lblShteti.Text = rm.GetString("Shteti", ci)+":";
            lblKomuna.Text = rm.GetString("Komuna", ci) + ":";
            lblVendi.Text = rm.GetString("Vendi", ci) + ":";
            lblRruga.Text = rm.GetString("Rruga", ci) + ":";
            lblNrV.Text = rm.GetString("nrVend", ci) + ":";
            lblSqarime.Text = rm.GetString("sqarime", ci) + ":";
            btnRegjistro.Text = rm.GetString("lblRegjistro", ci);
            btnAnulo.Text = rm.GetString("Pastro", ci);
        }     

        private void frmRegjistro_Load(object sender, EventArgs e)
        {
            MbushiKombot();
        }
       
         private void btnRegjistro_Click(object sender, EventArgs e)
        {
            string _Query = "";
            
             try
             {
                _Query = "Insert Into tblAdresa (Komuna,Vendi,Rruga," +
                    "Nr_Vendbanimit,Shteti,Sqarime,Latitude,Longitude,DataRegjistrimit, Perdoruesi) VALUES ('" +
                    cboKomuna.Text + "','" + txtVendi.Text + "','" + txtRruga.Text + "','" 
                    + txtNrVendbanimit.Text +"','"+ txtShteti.Text + "','" + txtSqarime.Text + "','" 
                    + txtLatitude.Text +"','"+txtLongitude.Text + "',GetDate(),'" +Parametrat._username + "')";

                string _Mesazhi = objDB.InsUpdDel(_Query);
                if (_Mesazhi == "")
                {
                    _Mesazhi = "Të dhenat u ruajtën me sukses!";
                    this.Pastro();
                }
                MessageBox.Show(_Mesazhi);
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

         private void Pastro()
         {
             txtVendi.Clear();
             txtRruga.Clear();
             cboKomuna.SelectedIndex = -1;
             txtNrVendbanimit.Clear();
             txtSqarime.Clear();
             txtLatitude.Clear();
             txtLongitude.Clear();
         }

         public void MbushiKombot()
         {
             DataSet _Shenimet = objDB.LexoShenimet("Select * From tblKomuna;");
             if (objDB.MesazhGabimi == "")
             {
                 cboKomuna.DataSource = _Shenimet.Tables[0];
                 cboKomuna.DisplayMember = "Emri";
                 cboKomuna.ValueMember = "Id";
                 
                 cboKomuna.SelectedIndex = -1;
             }
             else MessageBox.Show("GABIM Ne Koneksion me DB \n\n" + objDB.MesazhGabimi);
         }

         private void btnAnulo_Click(object sender, EventArgs e)
         {
             this.Pastro();
         }

         private void cboKomuna_KeyPress(object sender, KeyPressEventArgs e)
         {
             //ValidimFushash(sender, e, "shkronja");
         }

         private void txtVendi_KeyPress(object sender, KeyPressEventArgs e)
         {
             ValidimFushash(sender, e, "shkronja");
         }

         private void txtRruga_KeyPress(object sender, KeyPressEventArgs e)
         {
             ValidimFushash(sender, e, "shkronja");
         }

         private void txtNrVendbanimit_KeyPress(object sender, KeyPressEventArgs e)
         {
             ValidimFushash(sender, e, "numra");
         }

         private void txtLatitude_KeyPress(object sender, KeyPressEventArgs e)
         {
             ValidimFushash(sender, e, "numra dhe pika");
         }

         private void txtLongitude_KeyPress(object sender, KeyPressEventArgs e)
         {
             ValidimFushash(sender, e, "numra dhe pika");
         }

         private void txtSqarime_KeyPress(object sender, KeyPressEventArgs e)
         {
             ValidimFushash(sender, e, "shkronja, numra dhe pika");
         }

         private void ValidimFushash(object sender, KeyPressEventArgs e, string mundesia)
         {
             switch(mundesia)
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

                case "numra":
                    if ((e.KeyChar < 48 || e.KeyChar > 57)
                                    && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 127)
                        e.Handled = true; 
                    break;

                case "numra dhe pika":
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 44 && e.KeyChar != 46
                                   && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 127)
                        e.Handled = true; 
                    break;
            }
             
         }

         private void pictureBox1_Click(object sender, EventArgs e)
         {
              this.Close();
         }
        string ndihma = "";
        int VisibleTime = 2000;  //ne millisekonda       
            
         private void cboKomuna_Enter(object sender, EventArgs e)
        {

        }

         private void txtVendi_Enter(object sender, EventArgs e)
         {
             if (Parametrat._Gjuha == "Anglisht")
                 ndihma = "Write place";
             else if (Parametrat._Gjuha == "Shqip")
                 ndihma = "Shkruaj vendin";

             TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
             ToolTip tt = new ToolTip();                                         //tooltip
             tt.Show(ndihma, tb, cboKomuna.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
         }

         private void txtRruga_Enter(object sender, EventArgs e)
         {
             if (Parametrat._Gjuha == "Anglisht")
                 ndihma = "Write street";
             else if (Parametrat._Gjuha == "Shqip")
                 ndihma = "Shkruaj rrugen";

             TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
             ToolTip tt = new ToolTip();                                         //tooltip
             tt.Show(ndihma, tb, cboKomuna.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
         }

         private void txtNrVendbanimit_Enter(object sender, EventArgs e)
         {
             if (Parametrat._Gjuha == "Anglisht")
                 ndihma = "Write street number";
             else if (Parametrat._Gjuha == "Shqip")
                 ndihma = "Shkruaj numrin e rruges";

             TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
             ToolTip tt = new ToolTip();                                         //tooltip
             tt.Show(ndihma, tb, cboKomuna.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
         }

         private void txtLatitude_Enter(object sender, EventArgs e)
         {
             if (Parametrat._Gjuha == "Anglisht")
                 ndihma = "Write possition Latitude";
             else if (Parametrat._Gjuha == "Shqip")
                 ndihma = "Shkruaj pozicionin, Latituden";

             TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
             ToolTip tt = new ToolTip();                                         //tooltip
             tt.Show(ndihma, tb, cboKomuna.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
         }

         private void txtLongitude_Enter(object sender, EventArgs e)
         {
             if (Parametrat._Gjuha == "Anglisht")
                 ndihma = "Write possition, Longitude";
             else if (Parametrat._Gjuha == "Shqip")
                 ndihma = "Shkruaj pozicionin, Longituden";

             TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
             ToolTip tt = new ToolTip();                                         //tooltip
             tt.Show(ndihma, tb, cboKomuna.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
         }

         private void txtSqarime_Enter(object sender, EventArgs e)
         {
             if (Parametrat._Gjuha == "Anglisht")
                 ndihma = "Write explaination for this place";
             else if (Parametrat._Gjuha == "Shqip")
                 ndihma = "Shkruaj sqarimet per vendin me gjeresisht";

             TextBox tb = (TextBox)sender;                                       //krijimi i obj te textbox 
             ToolTip tt = new ToolTip();                                         //tooltip
             tt.Show(ndihma, tb, cboKomuna.Size.Width, 5, VisibleTime);    //shfaqet ky mesazh
         }

         private void frmRegjistroAdresa_Load(object sender, EventArgs e)
         {
             // TODO: This line of code loads data into the 'menaxhimiIAdresaveDataSet.tblKomuna' table. You can move, or remove it, as needed.
             this.tblKomunaTableAdapter.Fill(this.menaxhimiIAdresaveDataSet.tblKomuna);

         }
        
    }
}
