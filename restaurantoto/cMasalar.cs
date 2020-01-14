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

        public string SessionSum(int state,string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select TARIH,MasaId From adisyonlar Right Join Masalar on adisyonlar.MasaId = Masalar.ID Where " +
                "Masalar.DURUM = @durum and adisyonlar.Durum = 0 and masalar.ID = @masaId",con);

            SqlDataReader dr = null;

            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["TARIH"]).ToString();
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


        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;

            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }


        public bool TableGetbyState(int ButtonName , int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select durum From Masalar Where Id=@TableId and DURUM=@state", con);

            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;

            try
            {

                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

        public void setChangeTableState(string ButonName, int state)
        {

            SqlConnection con = new SqlConnection(gnl.conString);

            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM=@Durum where ID=@MasaNo", con);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();

            }

            string aa = ButonName;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }

    }
}
