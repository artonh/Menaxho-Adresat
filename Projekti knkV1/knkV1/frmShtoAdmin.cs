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
    public partial class frmShtoAdmin : Form
    {
        public frmShtoAdmin()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Add Administrator";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Shto administrator";
            }
        }


        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            //lblUsername.Text = rm.GetString("user", ci) + ":";
            //lblPassword.Text = rm.GetString("pass", ci) + ":";
            //lblEmri.Text = rm.GetString("Emri", ci) + ":";
            //lblMbiemri.Text = rm.GetString("Mbiemri", ci) + ":";
            //lblGjinia.Text = rm.GetString("Gjinia", ci) + ":";
            //rbtMashkull.Text = rm.GetString("Mashkull", ci);
            //rbtFemer.Text = rm.GetString("Femer", ci);
            //label1.Text = rm.GetString("Datelindja", ci) + ":";
            //btnKonfirmo.Text = rm.GetString("Konfirmo", ci);
            //btnAnulo.Text = rm.GetString("Anulo", ci);
        }
        LidhjaMeDB objDB = new LidhjaMeDB();
        string Query = "";

        private void frmShtoAdmin_Load(object sender, EventArgs e)
        {
            KerkoNeDB();
        }

        private void KerkoNeDB()
        {
            Query = "Select * from tblPerdoruesi where GrupiID = 2";

            DataSet ds1 = objDB.LexoShenimet(Query);
            if (objDB.MesazhGabimi != "")
            {
                MessageBox.Show(objDB.MesazhGabimi);
                return;
            }
            dgvKlientiLista.DataSource = ds1.Tables[0];
            dgvKlientiLista.Columns["Password"].Visible = false;
            dgvKlientiLista.Columns["DataRegjistrimit"].Visible = false;
            dgvKlientiLista.Columns["Gjinia"].Visible = false;
            dgvKlientiLista.Columns["Salt"].Visible = false;

        }

        private void btnParaqit_Click(object sender, EventArgs e)
        {
            Query = "UPDATE tblPerdoruesi set GrupiID=1 where username='"+txtKerkoModifiko2.Text+"'";
            objDB.InsUpdDel(Query);
            if (objDB.MesazhGabimi == "")
            {
                MessageBox.Show("Keni shtuar nje admin me sukses!", "Njoftim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Operacioni nuk eshte kryer me sukses!", "Njoftim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KerkoNeDB();
        }


        private void dgvKlientiLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _indeksi = dgvKlientiLista.CurrentRow.Index;
            txtKerkoModifiko2.Text = dgvKlientiLista.Rows[_indeksi].Cells["username"].Value.ToString();
            int _GrupiID = int.Parse(dgvKlientiLista.Rows[_indeksi].Cells["GrupiID"].Value.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
