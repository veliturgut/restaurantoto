using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantoto
{
    class cMasalar
    {

        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY;
        #endregion

        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int KAPASITE
        {
            get { return _KAPASITE; }
            set { _KAPASITE = value; }
        }

        public int SERVISTURU
        {
            get { return _SERVISTURU; }
            set { _SERVISTURU = value; }
        }

        public int DURUM
        {
            get { return _DURUM; }
            set { _DURUM = value; }
        }

        public int ONAY
        {
            get { return _ONAY; }
            set { _ONAY = value; }
        }
        #endregion 


        cGenel gnl = new cGenel();

        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaId From adisyonlar Right Join Masalar on adisyonlar.MasaId = Masalar.ID Where Masalar.DURUM = @durum " +
                "and Adisyon.Durum = 0",con);

            SqlDataReader dr = null;

            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }

            return dt;
        }

    }
}
