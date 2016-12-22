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
    public partial class frmStatistika : Form
    {
        LidhjaMeDB objDB = new LidhjaMeDB();
        public frmStatistika()
        {
            InitializeComponent();
            if (Parametrat._Gjuha == "Anglisht")
            {
                CultureInfo ci = new CultureInfo("en-US");
                NdrroGjuhen(ci, "knkV1.Lang.langres");
                this.Text = "Statistics";
            }
            else if (Parametrat._Gjuha == "Shqip")
            {
                CultureInfo ci = new CultureInfo("al-AL");
                NdrroGjuhen(ci, "knkV1.Lang.langres.al");
                this.Text = "Statistikat";
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

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics objGrafika = e.Graphics;
            //
            // ne grafik disa vlera duhet te jene dinamike, ndersa vendosja e boshteve eshte statike
            // vlerat dinamike jane deklaruar me poshte
            //
            //lartesiaYx=230 ku x eshte cfaredo numri, 230 eshte lartesi maximale dmth 100%
           int gjersia = 110, x = 120, d = 5, y=287;  //x eshte pika fillestare, d eshte distanca, y eshte gjatesia e vijes ne Y
            int lartesiaY1 =200, lartesiaY2 = 100, lartesiaY3 = 150, lartesiaY4 = 70;

            string Query = "SELECT (Select Count(IDaddr) from tblAdresa where DataRegjistrimit between '2016-01-01' and '2016-03-31') as 'tremujori1'," +
                "(Select Count(IDaddr)  from tblAdresa where DataRegjistrimit between '2016-04-01' and '2016-06-30') as 'tremujori2'," +
                "(Select Count(IDaddr)  from tblAdresa where DataRegjistrimit between '2016-07-01' and '2016-09-30') as 'tremujori3'," +
                "(Select Count(IDaddr)  from tblAdresa where DataRegjistrimit between '2016-09-01' and '2016-12-31') as 'tremujori4';";

            DataSet ds1 = objDB.LexoShenimet(Query);
            if (objDB.MesazhGabimi != "")
            {
                MessageBox.Show(objDB.MesazhGabimi);
                return;
                
            }
            dataGridView1.DataSource = ds1.Tables[0];

            int _indeksi = 0;
            lartesiaY1 = int.Parse(dataGridView1.Rows[_indeksi].Cells["tremujori1"].Value.ToString()) * 15;
            lartesiaY2 = int.Parse(dataGridView1.Rows[_indeksi].Cells["tremujori2"].Value.ToString()) * 15;
            lartesiaY3 = int.Parse(dataGridView1.Rows[_indeksi].Cells["tremujori3"].Value.ToString()) * 15;
            lartesiaY4 = int.Parse(dataGridView1.Rows[_indeksi].Cells["tremujori4"].Value.ToString()) * 15;
            
            //pjesa e lartesis se Ynit duhet te varet nga DB ajo duhet te rritet por njekohsisht duhet te zvogloj lokacionin.Y
            Rectangle katrori1 = new Rectangle(x, y - lartesiaY1, gjersia, lartesiaY1); //duhet te filloj ne y = - gjatesia e tij
            Rectangle katrori2 = new Rectangle(x + gjersia + d, y - lartesiaY2, gjersia, lartesiaY2);   //per secilin katror kemi llogarit x-in ku do te fillojne 135 + gjersia e katrorit1 dhe + 5 distanc
            Rectangle katrori3 = new Rectangle(x + 2 * gjersia + 2 * d, y - lartesiaY3, gjersia, lartesiaY3);//+2*88 eshte pika ku fillon katrori 2 dhe + 2*5 eshte distanca e vogel mes
            Rectangle katrori4 = new Rectangle(x + 3 * gjersia + 3 * d, y - lartesiaY4, gjersia, lartesiaY4); //
            Rectangle Prapavija100 = new Rectangle(x - d + 1, y - 230, 4 * gjersia + 4 * d + 20, 230); //
            Rectangle Prapavija75 = new Rectangle(x - d + 1, y - 115 - 115 / 2 , 4 * gjersia + 4 * d + 20, 115 + 115 / 2 ); //
            Rectangle Prapavija50 = new Rectangle(x - d + 1, y - 115, 4 * gjersia + 4 * d + 20, 115); //
            Rectangle Prapavija25 = new Rectangle(x - d + 1, y - 115 / 2, 4 * gjersia + 4 * d + 20, 115 / 2); //
            
            //vizatimi i boshtit X
            objGrafika.DrawLine(Pens.Black, 115, 287, 569 + 90, 287);//vija horizontale - abshisa/X
            objGrafika.DrawLine(Pens.Black, 569 + 90, 287, 569 + 90 - 15, 287 - 7);// X - viza e shigjetes ana e eperme
            objGrafika.DrawLine(Pens.Black, 569 + 90, 287, 569 + 90 - 15, 287 + 7);// X - viza e shigjetes ana e poshtme
            objGrafika.DrawString("Koha", new Font("Arial", 12), Brushes.Black, 569 + 80 - 30, 287 + 7+4);  
            //vizatimi i boshtit Y 
            objGrafika.DrawLine(Pens.Black, 115, 287, 115, 18); // vija vertikale - ordinata/Y
            objGrafika.DrawLine(Pens.Black, 115, 18, 115 - 7, 18 + 15);// Y - viza e shigjetes ana e majt
            objGrafika.DrawLine(Pens.Black, 115, 18, 115 + 7, 18 + 15);// Y - viza e shigjetes ana e djathte
            objGrafika.DrawString("Nr.", new Font("Arial", 11), Brushes.Black, 115 - 35, 18 +2);
            
            SolidBrush Bush_prapavija100=new SolidBrush(Color.FromArgb(100,147, 112, 219));
            SolidBrush Brush_prapavija75 = new SolidBrush(Color.FromArgb(100, 177, 155, 222));
            SolidBrush Brush_prapavija50 = new SolidBrush(Color.FromArgb(100, 166, 137, 224));
            SolidBrush Brush_prapavija25 = new SolidBrush(Color.FromArgb(100, 140, 100, 222));
            //Vizatimi i prapavijes se grafikut
            objGrafika.FillRectangle(Bush_prapavija100, Prapavija100);
            objGrafika.FillRectangle(Brush_prapavija75, Prapavija75);
            objGrafika.FillRectangle(Brush_prapavija50, Prapavija50);
            objGrafika.FillRectangle(Brush_prapavija25, Prapavija25);
            //vizatimi i kolonave 
            objGrafika.FillRectangle(Brushes.DeepSkyBlue, katrori1); //per 3Mujorin I (3M I)
            objGrafika.FillRectangle(Brushes.Aquamarine, katrori2); //per 3M II
            objGrafika.FillRectangle(Brushes.PaleGreen, katrori3);//per 3M III
            objGrafika.FillRectangle(Brushes.DarkSeaGreen, katrori4);//per 3M IV
            
            //ktu duhet te deklarohet nje string qe merr vlere nga DB sa perqindje ka
            //dhe meqe nuk po dime se si behet % ateher e bejme nje llogaritje dhe ne switch e vendosim sa eshte % ne string
            
            //vlerat pershkruese brenda kolonave se sa jane te mbushura ato
            //objGrafika.DrawString("50%", new Font("Arial", 12), Brushes.Red, x + (gjersia / 2) - 20, (y - lartesiaY1)*2);  //vlerat pershkruese per kolonat 3Muj I
            //objGrafika.DrawString("30%", new Font("Arial", 12), Brushes.Red, x + 2 * gjersia-70, (y - lartesiaY2/2)); //per 3Muj II
            //objGrafika.DrawString("45%", new Font("Arial", 12), Brushes.Red, x + 3 * gjersia - 60, (y - lartesiaY3 / 2)); //per 3Muj III
            //objGrafika.DrawString("25%", new Font("Arial", 12), Brushes.Red, x + 4 * gjersia - 55, (y - lartesiaY4 / 2)); //per 3Muj IV

            //vendosja e stringut ne boshtin-Y si njesi matese 
            objGrafika.DrawString("100", new Font("Arial", 11), Brushes.Black, x - 45, y - 230 - 8);          
            objGrafika.DrawString("75", new Font("Arial", 11), Brushes.Black, x - 45, y - 115 - 115 / 2 - 8); //Vlerat konstante ne Y
            objGrafika.DrawString("50", new Font("Arial", 11), Brushes.Black, x - 45, y - 115 - 8);           //Vlerat ne Y
            objGrafika.DrawString("25", new Font("Arial", 11), Brushes.Black, x - 45, y - 115/2 - 8);         //Vlerat ne Y
            objGrafika.DrawString("0", new Font("Arial", 11), Brushes.Black, x - 45, y - 8);        //Vlerat ne Y

            //vendosja e stringut ne boshtin-X si njesi matese kohore 3Mujori 
            objGrafika.DrawString("3 Mujori I", new Font("Arial", 11), Brushes.Black, x + (gjersia / 2) - 40, 287 + 7 + 4); 
            objGrafika.DrawString("3 Mujori II", new Font("Arial", 11), Brushes.Black, x + 2 * gjersia-90, 287 + 7 + 4); //pershkrimi i kolonave
            objGrafika.DrawString("3 Mujori III", new Font("Arial", 11), Brushes.Black, x + 3 * gjersia - 80, 287 + 7 + 4); //pershkrimi i kolonave
            objGrafika.DrawString("3 Mujori IV", new Font("Arial", 11), Brushes.Black,  x+4 * gjersia - 75, 287 + 7 + 4); //pershkrimi i kolonave

            //stringu per pershkrimin e figures
            objGrafika.DrawString("Fig.1:  Vlerat statistikore të regjistrimeve të adresave gjatë vitit", new Font("Arial", 12), Brushes.Black, 154, 383); 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
