using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace restaurantoto
{
    class cSiparis
    {
        cGenel gnl = new cGenel();

        #region Fields
        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private int _adet;
        private int _masaId;
        #endregion 

        #region Properties
        public int ID
        {
            get { return _Id;}
            set { _Id = value; }
        }

        public int MasaId
        {
            get{ return _masaId; }
            set { _masaId = value; }
        }

        public int AdisyonId
        {
            get { return _adisyonID; }
            set { _adisyonID = value; }
        }

        public int UrunId
        {
            get { return _urunId; }
            set { _urunId = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }
        #endregion


        //Siparişleri Getir
        public void getByOrder(ListView lv, int AdisyonId)
        {

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select URUNAD,FİYAT,Satislar.ID,satislar.URUNID,satislar.ADET from satislar Inner Join " +
                "urunler on Satislar.URUNID = Urunler.ID Where ADISYONID = @AdisyonId", con);
            SqlDataReader dr = null;

            cmd.Parameters.Add("@AdisyonId", SqlDbType.Int).Value = AdisyonId;

            try
            {

                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;

                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FİYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());

                    sayac++;
                }


            }
            catch(SqlException ex) 
            {
                string hata = ex.Message;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

        }

    }
}
