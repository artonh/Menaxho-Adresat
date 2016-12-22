using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace knkV1
{
    class LidhjaMeDB
    {
        public string MesazhGabimi = "";

        public DataSet LexoShenimet(string Query)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            SqlCommand objKomanda = new SqlCommand(Query, objKonektimi);
            SqlDataAdapter objAdapteri = new SqlDataAdapter(objKomanda);
            DataSet _Shenimet = new DataSet();
            try
            {
                objKonektimi.Open();
                objAdapteri.Fill(_Shenimet);
                MesazhGabimi = "";
            }
            catch (Exception ex) { MesazhGabimi = ex.Message; }
            finally { objKonektimi.Close(); }
            return _Shenimet;
        }

        public string InsUpdDel(string Query)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametrat._KonektimiDB);
            SqlCommand objKomanda = new SqlCommand(Query, objKonektimi);
            try
            {
                objKonektimi.Open();
                objKomanda.ExecuteNonQuery();
                MesazhGabimi = "";
            }
            catch (Exception ex) { MesazhGabimi = ex.Message; }
            finally { objKonektimi.Close(); }
            return MesazhGabimi;           //nese mbushet MesazhGabimi atehere e dijme qe ka pas gabim
        }

    }
}
