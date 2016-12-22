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
    public partial class frmModifiko : Form
    {
        LidhjaMeDB objDB = new LidhjaMeDB();
        string Query = "";

        public frmModifiko()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Modify address";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Modifiko adresen";
            }
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            lblKerkoAdresa.Text = rm.GetString("lblKerko", ci) + ":";
            btnParaqitAdresat.Text = rm.GetString("Paraqit", ci);
            btnRuajMofiko.Text = rm.GetString("ModifikoAdresen", ci) ;
        }

        private void txtZgjedhRrugen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void txtZgjedhQytetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void txtVendi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void cboQyteti_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void txtEmriRrugesß1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "shkronja");
        }

        private void txtNumriRrugesß2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "numra");
        }

        private void txtLatitudeß3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "numra dhe pika");
        }

        private void txtLongitudeß4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidimFushash(sender, e, "numra dhe pika");
        }

        private void rtbSqarime5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnParaqitAdresat_Click(object sender, EventArgs e)
        {
            KerkoNeDB();
        }

        private void KerkoNeDB()
        {
            Query = "Select * from tblAdresa";
                
            DataSet ds1 = objDB.LexoShenimet(Query);
            if (objDB.MesazhGabimi != "")
            {
                MessageBox.Show(objDB.MesazhGabimi);
                return;
            }
            dgvKlientiLista.DataSource = ds1.Tables[0];
            dgvKlientiLista.Columns["Shteti"].Visible = false;
            dgvKlientiLista.Columns["IDaddr"].Visible = false;
        }

        private void btnRuajMofiko_Click(object sender, EventArgs e)
        {
            try
            {   //qe te dihet se cili rresht i dgv-s po deshiron perdoruesi ta zgjedh
                int _indeksi = dgvKlientiLista.CurrentRow.Index;
                int _IDaddr = int.Parse(dgvKlientiLista.Rows[_indeksi].Cells["IDaddr"].Value.ToString());
                string _Komuna = dgvKlientiLista.Rows[_indeksi].Cells["Komuna"].Value.ToString();
                string _Vendi = dgvKlientiLista.Rows[_indeksi].Cells["Vendi"].Value.ToString();
                string _Rruga = dgvKlientiLista.Rows[_indeksi].Cells["Rruga"].Value.ToString();
                int _NrV = int.Parse(dgvKlientiLista.Rows[_indeksi].Cells["Nr_Vendbanimit"].Value.ToString());
                string _Shteti = dgvKlientiLista.Rows[_indeksi].Cells["Shteti"].Value.ToString();
                string _Sqarime = dgvKlientiLista.Rows[_indeksi].Cells["Sqarime"].Value.ToString();
                float _Latitude = float.Parse(dgvKlientiLista.Rows[_indeksi].Cells["Latitude"].Value.ToString());
                float _Longitude = float.Parse(dgvKlientiLista.Rows[_indeksi].Cells["Longitude"].Value.ToString());

                frmRegjistroAdresa objRA = new frmRegjistroAdresa(_IDaddr, _Komuna,_Vendi, _Rruga, _NrV, _Shteti, _Sqarime, _Latitude, _Longitude);
                objRA.ShowDialog(this);
                KerkoNeDB();
                
            }
            catch { MessageBox.Show("Ju lutemi, zgjedhni shenimet nga lista"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds1 = objDB.LexoShenimet("SELECT * FROM tblAdresa where Komuna like '%" + txtKerkoModifiko.Text + "%' OR " +
                "Vendi LIKE '%" + txtKerkoModifiko.Text + "%' "+
                " OR Rruga LIKE '%" + txtKerkoModifiko.Text + "%'"+
                " OR Nr_Vendbanimit LIKE '%" + txtKerkoModifiko.Text + "%'"+
                " OR Sqarime LIKE '%" + txtKerkoModifiko.Text + "%'"+
                " OR Latitude LIKE '%" + txtKerkoModifiko.Text + "%'"+
                " OR Longitude LIKE '%" + txtKerkoModifiko.Text + "%'");
            if (objDB.MesazhGabimi != "")
            {
                MessageBox.Show(objDB.MesazhGabimi);
                return;
            }
            dgvKlientiLista.DataSource = ds1.Tables[0];
            dgvKlientiLista.Columns["IDaddr"].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
    }
}
