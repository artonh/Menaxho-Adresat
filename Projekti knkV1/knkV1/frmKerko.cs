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
    public partial class frmKerko : Form
    {
        LidhjaMeDB objDB = new LidhjaMeDB();
        public frmKerko()
        {
            InitializeComponent();
            dgvAdresa.Location = new Point(2, 146);
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Find address";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Kerko adresen";
            }
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            btnShfaqTeGjitha.Text = rm.GetString("Paraqit", ci);
            btnVendi.Text = rm.GetString("FiltroSipasVendit", ci);
            btnRruga.Text = rm.GetString("FiltroSipasRruges", ci);
            btnVendbanimi.Text = rm.GetString("FiltroSipasVendbanimi", ci);
            grTeGjitha.Text = rm.GetString("lblKerko", ci);
            btnDilNgaTeGjitha.Text = rm.GetString("kthehu", ci);
            btnKomuna.Text = rm.GetString("FiltroSipasKomunes", ci);
            btnPozita.Text = rm.GetString("FiltroSipasPozites", ci);
            grKerko.Text = rm.GetString("lblKerko", ci);
            grKerkoPozite.Text = rm.GetString("FiltroSipasPozites", ci);
            btnKthehu.Text = rm.GetString("kthehu", ci);
            btnKthehuGrKerkoPozite.Text = rm.GetString("kthehu", ci);
            btngrKerkoKerkoPozite.Text = rm.GetString("lblKerko", ci);
        }     

        string Query = "", Kerkesa="";             

        private void btnRruga_Click(object sender, EventArgs e)
        {
            RindertoFormen();
            string q = "";
            if (Parametrat._Gjuha == "Anglisht") q = "Find by street";
                else q = "Kerko sipas rruges";

            grKerko.Text = q;
            Kerkesa = "Rruga";
        }

        private void btnKomuna_Click(object sender, EventArgs e)
        {
            RindertoFormen();
            string q = "";
            if (Parametrat._Gjuha == "Anglisht") q = "Find by municipalities";
            else q = "Kerko sipas Komunes";
            grKerko.Text = q;
            
            Kerkesa = "Komuna";
        }

        private void btnVendi_Click(object sender, EventArgs e)
        {
            RindertoFormen();
            string q = "";
            if (Parametrat._Gjuha == "Anglisht") q = "Find by place";
            else q = "Kerko sipas vendit";
            grKerko.Text = q;

            Kerkesa = "Vendi";
        }

        private void btnVendbanimi_Click(object sender, EventArgs e)
        {
            RindertoFormen();
            string q = "";
            if (Parametrat._Gjuha == "Anglisht") q = "Find by street nr";
            else q = "Kerko sipas numrit te vendbanimit";
            grKerko.Text = q;
            
            Kerkesa = "Nr_Vendbanimi";
        }

        private void btnPozita_Click(object sender, EventArgs e)
        {
            RindertoFormen();
            grKerko.Visible = false;
            grKerkoPozite.Location = new Point(grKerko.Location.X, pnlMundesi.Location.Y);
            grKerkoPozite.Visible = true;
           
            Kerkesa = "Pozita";
        }

        private void btnShfaqTeGjitha_Click(object sender, EventArgs e)
        {
            RindertoFormen();
            grKerko.Visible = false;
            string q = "";
            if (Parametrat._Gjuha == "Anglisht") q = "All address";
            else q =  "Te gjitha adresat ";
            grTeGjitha.Text = q;
            grTeGjitha.Visible = true;
            
            Kerkesa = "TeGjitha";
            KerkoNeDB(Kerkesa);
        }
        
        private void btnKthehu_Click(object sender, EventArgs e)
        {
            pnlMundesi.Visible = true;
            grKerko.Visible = false;
            pnlMundesi.Location = new Point(234, 0);
            txtKerko.Text = "";

            Query = "";
        }

         private void btnDilNgaTeGjitha_Click(object sender, EventArgs e)
        {
            pnlMundesi.Visible = true;
            grKerko.Visible = false;
            grTeGjitha.Visible = false;
            pnlMundesi.Location = new Point(234, 0);
            
            Query = "";
            txtKerko.Text = "";
        }

         private void btnKthehuGrKerkoPozite_Click(object sender, EventArgs e) //buton ne  grB special per kerkim me pozite
         {
             pnlMundesi.Visible = true;
             grKerkoPozite.Visible = false;
             grTeGjitha.Visible = false;
             pnlMundesi.Location = new Point(234, 0);

             Query = "";
             txtLatitudeGrKerko.Text = "";
             txtLongitudeGrKerko.Text = "";
         }

         private void btngrKerkoKerkoPozite_Click(object sender, EventArgs e)//buton ne  grB special per kerkim me pozite
         {
             string q,a;
             if (Parametrat._Gjuha == "Anglisht") { q = "Warning, fill form!"; a = "Warning"; }
             else { q = "Verejtje, mbusheni fushen!"; a = "Verejtje"; }
             if (txtLongitudeGrKerko.Text != "" || txtLatitudeGrKerko.Text != "")
                 KerkoNeDB(Kerkesa);
             else MessageBox.Show(q, a, MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }

        private void txtKerko_TextChanged(object sender, EventArgs e)       
        {              
                KerkoNeDB(Kerkesa);           
        }

        private void KerkoNeDB(string kerkes) 
        {            
            switch (kerkes)
            {
                case "TeGjitha": Query = "Select * from tblAdresa"; break;
                case "ID": Query = "Select * From tblAdresa Where IDaddr like '%" + txtKerko.Text + "%'"; break;
                case "Rruga": Query = "Select * From tblAdresa Where Rruga like '" + txtKerko.Text + "%'"; break;
                case "Komuna": Query = "Select * From tblAdresa Where Komuna like '" + txtKerko.Text + "%'"; break;
                case "Vendi": Query = "Select * From tblAdresa Where Vendi like '" + txtKerko.Text + "%'"; break;
                case "Nr_Vendbanimi": Query = "Select * From tblAdresa Where Nr_Vendbanimit like '%" + txtKerko.Text + "%'"; break;
                case "Pozita":
                    string latituda = txtLatitudeGrKerko.Text;
                    string longituda = txtLongitudeGrKerko.Text;                        
                    Query = "Select * From tblAdresa Where Latitude like '%" + latituda + "%' AND Longitude like '%" + longituda + "%'";
                        break; 
                default: break;
            }

            DataSet ds1 = objDB.LexoShenimet(Query);
            if (objDB.MesazhGabimi != "")
            {
                MessageBox.Show(objDB.MesazhGabimi);
                return;
            }
            dgvAdresa.DataSource = ds1.Tables[0];
            dgvAdresa.Columns["Shteti"].Visible = false;
            dgvAdresa.Columns["IDaddr"].Visible = false;
             }

        private void RindertoFormen()
        {
            grKerko.Visible = true;     //Grupboxi shfaqet            
            pnlMundesi.Visible = false; //zhduket paneli 
            dgvAdresa.Visible = true;   //dgv shfaqet
            
            grKerko.Location = new Point(grKerko.Location.X, pnlMundesi.Location.Y + 20);

            this.Size = new Size(965, 490);
            dgvAdresa.Location = new Point(2, 146);

            
        }

        private void txtKerko_KeyPress(object sender, KeyPressEventArgs e)
        {
            //karakteret qe nuk jane shkronja kane kodin: < 65 ||  > 90 
            //karakteret qe nuk jane numra kane kodin: <48 dhe >57
            //space 32  //backspace = 8   //DEL=127  //- = 45  //, =44    //.=46  
            if (((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 96 || e.KeyChar > 122))
                            && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) &&
                            e.KeyChar != 32 && e.KeyChar != 45 && e.KeyChar != 44
                            && e.KeyChar != 46  && e.KeyChar != 127)
                e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      


    }
}
