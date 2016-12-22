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
    public partial class frmRrethNesh : Form
    {

        int nr = 1;
        public frmRrethNesh()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "About us";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Rreth nesh";
            }
        
            string em = "", mb = "", dt = "", email = "", nrtel = "";
            if (nr == 1)
            {
                em = "Arton";
                mb = "Hoti";
                dt = "03.06.1994";
                email = "arti._3@hotmail.com";
                nrtel = "045/508-626";
            }
            lblEmri1.Text = em;
            lblMbiemri1.Text = mb;
            lblDatelindja1.Text = dt;
            lblEmail1.Text = email;
            lblNrTel1.Text = nrtel;
            lblProfesioni1.Text = "Student";
            lblNumri.Text = nr.ToString();
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            lblEmri.Text = rm.GetString("Emri", ci) + ":";
            lblMbiemri.Text = rm.GetString("Mbiemri", ci) + ":";
            lblDatelindja.Text = rm.GetString("Datelindja", ci) + ":";
            lblProfesioni.Text = rm.GetString("Profesioni", ci) + ":";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRrethNesh_Load(object sender, EventArgs e)
        {
        }

        private void Next_Click(object sender, EventArgs e)
        {
            NdrroTeDhenat();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            NdrroTeDhenat();
        }

        private void NdrroTeDhenat() {
            string em = "", mb = "", dt = "", email = "", nrtel = "", us="";
            if (nr == 1)
            {
                em = "Arton";
                mb = "Hoti";
                dt = "03.06.1994";
                email = "arti._3@hotmail.com";
                nrtel = "045/508-626";
                us = "ah";
                pbAdmini.BackgroundImage = knkV1.Properties.Resources.ar11;
            }
            
            lblEmri1.Text = em;
            lblMbiemri1.Text = mb;
            lblDatelindja1.Text = dt;
            lblEmail1.Text = email;
            lblNrTel1.Text = nrtel;
            lblProfesioni1.Text = "Student";
            lblUser.Text = us;
            lblNumri.Text = nr.ToString();
        }
    }
}
