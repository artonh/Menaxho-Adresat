using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace knkV1
{
    static class Parametrat
    {
        public static string _username;
        public static int _GrupiID;
        public static string _EmriMbiemri;
        public static string _KonektimiDB = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public static string _Gjuha; //e perdorim per zgjedhjen e gjuhes qe ka bere perdoruesi
        
    }
}
