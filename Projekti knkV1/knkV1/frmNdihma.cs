using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knkV1
{
    public partial class frmNdihma : Form
    {
        public frmNdihma()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {                
                this.Text = "Help";
                label1.Text = "Click in buttons, for help!";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {               
                this.Text = "Ndihma";
                label1.Text = "Klikoni butonat, per ndihme!";
            }
        }
        string x = "";
        private void btnRegjistro_Click(object sender, EventArgs e)
        {            
            if (Parametrat._Gjuha == "Anglisht")            
                x = "Register Adress\n\nHere it is possible to register addresses. You can achieve this if initially fill all required fields with valid data and finally to press the RECORD. \n\nAplikacioni is designed such that if during registration address, any of the data is proven be in the form of non-valid, cease work and you announce to eventual error. \n\n You need to be loggin, with Keyboard combination CTRL+R ";       
            else if (Parametrat._Gjuha == "Shqip")
                x = "REGJISTRO ADRESE\n\nNe kete seksion eshte i mundur regjistrimi i adresave te ndryshme. Kete mund ta arrini ne qofte se fillimisht mbushni te gjitha fushat e kerkuara me te dhena valide dhe se fundmi te shtypni butonin REGJISTRO.\n\nAplikacioni eshte i dizajnuar i atille qe ne qofte se gjate regjistrimit te adreses, ndonje nga te dhenat eshte provuar te jete ne forme jo-valide, te nderpreje punen dhe te ju lajmroj per gabimin eventual. \n\n Ju duhet te logoheni, me kombinimin CTRL+R mund ta shfqeni kete";

            label1.Text = x;
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                x = "EDIT address \n \nIn this section is possible to be realized modfikimi address previously registered in the data base. Modification of addresses can be accomplished by selecting the address that you wish to modify and then pressing the edit button. Button will open a dialogue which will be possible to change data asej address. \n\nCareful: Rules for filling the data are worth the same as in the case when to record your address, so the program will not allow filling of forms with gabushme data. \n\n You need to be loggin, with Keyboard combination CTRL+M";          
            else if (Parametrat._Gjuha == "Shqip")
                x = "MODIFIKO ADRESE\n\nNe kete seksion eshte e mundur te realizohet modfikimi i adresave te regjistruara me pare ne bazen e shenimeve. Modifikimi i adresave mund te realizohet duke zgjedhur adresen qe deshironi t'a modifikoni dhe pastaj duke shtypur butonin modifiko. Butoni do te hap dialogun ku do te mund te ndrrohen te dhenat e asej adrese.\n\nKUJDES: Rregullat per mbushjen e te dhenave vlejne njejte sikur ne rastin kur duhet te regjistrojme adresa, andaj programi nuk do te lejoj mbushjen e formave me te dhena te gabushme.  \n\n Ju duhet te logoheni, me kombinimin CTRL+M mund ta shfqeni kete";

            label1.Text = x;
        }

        private void btnKekro_Click(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                x = "Address search \n\nIn this section is possible to be realized search of addresses that are registered in advance in the data base. Search can be done depending on the filters of different which are implemenuar, including search by street, municipality, country and position, but at the same time by RHT to show all the registered address. \n\nCareful: Coordinates must be written in the form Decimal figures. \n\n You need to be loggin, with Keyboard combination CTRL+F";
            else if (Parametrat._Gjuha == "Shqip")
                x = "KERKO ADRESE\n\nNe kete seksion eshte e mundur te realizohet kerkimi i adresave te cilat jane te regjistruara paraprakisht ne bazen e shenimeve. Kerkimi  mund te behet varesisht nga filtrat e ndryshem te cilat jane implemenuar, perfshire ketu kerkimin sipas rruges, komunes, vendit dhe pozites, mirepo njekohesisht duke mundsuar qe te shfaqen te gjitha adresat e  regjistruara.\n\nKUJDES: Koordinata duhet te shkruhen ne formen e shifrave decimale.\n\n Ju duhet te logoheni, me kombinimin CTRL+F mund ta shfqeni kete";

            label1.Text = x;
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                x = "Delete address \n\nIn this section is possible to larohet any address registered in advance to the database. \n\nAdresa removed by initially presented the list of addresses with the button or by filtering the addresses by name in advance of the end selected address desired LARGO and press the button. \n\nCareful: deleted Data can not be returned!  \n\n You need to be loggin, with Keyboard combination CTRL+D";
            else if (Parametrat._Gjuha == "Shqip")
                x = "LARGO ADRESE\n\nNe kete seksion eshte e mundur te larohet ndonje adrese e regjistruar paraprakisht ne bazen e shenimeve.\n\nAdresa largohet duke paraqitur fillimisht listen e adresave permes butonit apo duke filtruar adresat sipas emrit paraprakisht e ne fund zgjedhet adresa e deshiruar dhe shtypet butoni LARGO.\n\nKUJDES: Te dhenat e fshira nuk mund te kthehen!\n\n Ju duhet te logoheni, me kombinimin CTRL+D mund ta shfqeni kete";

            label1.Text = x;
        }

        private void btnRegjistroPerdorues_Click(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                x = "Register \n\nIn this section can be done to create new accounts in order to be a possible further navigation through aplikaccion. This is achieved by clicking the register button with pasttaj filling certain data fields. \n\n With Keyboard combination CTRL+P";
            else if (Parametrat._Gjuha == "Shqip")
                x = "REGJISTROHU \n\nNe kete seksion mund te behet krijimi i llogarive te reja ne menyre qe te jete i mundshem navigimi i metutjeshem neper aplikaccion. Kjo arrihet duke klikuar butonin regjistrohu e pasttaj duke mbushur me te dhena fushat e caktuara.\n\nMe kombinimin CTRL+P mund ta shfqeni kete";

            label1.Text = x;
        }

        private void frmNdihma_Load(object sender, EventArgs e)
        {
            if (Parametrat._Gjuha == "Anglisht")
                x = "Welcome to guide the application. \n\nClick on one of the side buttons, which depending on sesksion you need guidance.\n\nWith Keyboard Combination CTRL+G you can change application Language";
            else if (Parametrat._Gjuha == "Shqip")
                x = "Miresevini ne udhezuesin e aplikacionit.\n\nKliko ne njerin nga butonat anash, varesisht se per cilin sesksion keni nevoje per udhezime.\n\nMe kombinimet CTRL+G mund ta ndryshoni gjuhen e aplikacionit";

            label1.Text = x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrOra_Tick(object sender, EventArgs e)
        {
            tstKoha.Text = DateTime.Now.ToString("HH:mm:ss ");
        }


        

        
    }
}
