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
    public partial class frmFshij : Form
    {
        LidhjaMeDB objDB = new LidhjaMeDB();
        string Query = "";
        string _IDADRESA = "";

        public frmFshij()
        {
            InitializeComponent();

             if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Delete address";
            }
             else if (Parametrat._Gjuha == "Shqip")
             {
                 CultureInfo ci = new CultureInfo("al-AL");
                 NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                 this.Text = "Largo adresen";
             }
        }

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            lblKerkoAdresa.Text = rm.GetString("lblKerko", ci);
            btnParaqit.Text = rm.GetString("Paraqit", ci);
            btnFshij.Text = rm.GetString("lblFshij", ci);

        }       

        private void btnParaqit_Click(object sender, EventArgs e)
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

            private void txtKerkoModifiko_TextChanged(object sender, EventArgs e)
            {
                DataSet ds1 = objDB.LexoShenimet("SELECT * FROM tblAdresa where Komuna like '%" + txtKerkoModifiko2.Text + "%' OR " +
                "Vendi LIKE '%" + txtKerkoModifiko2.Text + "%' " +
                " OR Rruga LIKE '%" + txtKerkoModifiko2.Text + "%'" +
                " OR Nr_Vendbanimit LIKE '%" + txtKerkoModifiko2.Text + "%'" +
                " OR Sqarime LIKE '%" + txtKerkoModifiko2.Text + "%'" +
                " OR Latitude LIKE '%" + txtKerkoModifiko2.Text + "%'" +
                " OR Longitude LIKE '%" + txtKerkoModifiko2.Text + "%'");
                if (objDB.MesazhGabimi != "")
                {
                    MessageBox.Show(objDB.MesazhGabimi);
                    return;
                }
                dgvKlientiLista.DataSource = ds1.Tables[0];
                dgvKlientiLista.Columns["IDaddr"].Visible = false;
            }

            private void lblKerkoAdresa_Click(object sender, EventArgs e)
            {
                
            }

            private void btnFshij_Click(object sender, EventArgs e)
            {
                try
                {
                    DialogResult objDialogResult = MessageBox.Show("A jeni te sigurte qe deshironi ta fshini kete adrese?", "Largo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (objDialogResult == DialogResult.Yes)
                    {
                        int _indeksi = dgvKlientiLista.CurrentRow.Index;
                        _IDADRESA = dgvKlientiLista.Rows[_indeksi].Cells["IDaddr"].Value.ToString();

                        DataSet ds1 = objDB.LexoShenimet("Delete from tblAdresa where IDaddr = " + _IDADRESA);
                        if (objDB.MesazhGabimi != "")
                        {
                            MessageBox.Show(objDB.MesazhGabimi);
                            return;
                        }
                        //dgvKlientiLista.DataSource = ds1.Tables[0];
                        dgvKlientiLista.Columns["IDaddr"].Visible = false;
                        KerkoNeDB();
                        }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        

    }
}
