using System; //
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; //klasa e network mail qe ofron interface per dergimin e mail, klasat e gatshme mailaddres etj

using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo

namespace knkV1 //namespace deklaron nje hapsire qe permban nje seri elementesh te lidhura
{
    public partial class Kycja : Form //klasa parciale kur pjesa tjeter nuk shihet 
    {
        public Kycja() //konstruktori
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Identify with e-mail";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Identifikohu me email";
            }

        }                           //sender i referohet objektit qe thirre ate eventi, qe e thirr eventin
                                    //object sender eshte kontrolla per te cilin eshte aksioni , 

        private void NdrroGjuhen(CultureInfo ci, string q)
        {
            Assembly a = Assembly.Load("knkV1");
            ResourceManager rm = new ResourceManager(q, a);

            btnKycu.Text = rm.GetString("btnLog", ci);
            btnMbylle.Text = rm.GetString("Pastro", ci);
          
        }
        private void btnKycu_Click(object sender, EventArgs e)                              //kur shtypet butoni kycu
        {
            Dergo_Email frm = new Dergo_Email(txtNga.Text, txtPass.Text);                   //objekt i ri i klases
            if (String.IsNullOrEmpty(txtNga.Text) || String.IsNullOrEmpty(txtPass.Text))    //kontrollon nese teksti eshte null ose zbrazet 
            {
                MessageBox.Show("Ju lutem shkruani e-mailin dhe passwordin", "Gabim",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);                          //shfaqet ky mesazh
            }
            else        //perndryshe nese nuk eshte addresa dhe passi zbrazet
            {
                try     //provo :
                {   //var-it ja percakton tipin kompajlleri
                    var test = new MailAddress(txtNga.Text);        //testimi i email addreses
                    this.Hide();                                    //mshef kete forme
                    //event       //nese ipet ky event atehere beje edhe kete(this.Close)                
                    frm.Closed += (s, args) => this.Close();        //kur mbyllet forma dergo_email mbyllet krejt aplikacioni
                    frm.Show();                                     //shfaq formen dergo email
                }
                catch (FormatException)                             //nese ndodh gabimi qe email nuk eshte si duhet 
                {
                    MessageBox.Show("Ju lutemi shkruani nje e-mail valide","Gabim",         
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                  
            }
            
        }

        private void btnMbylle_Click(object sender, EventArgs e)        
        {
            txtNga.Clear();
            txtPass.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
