using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace restaurantoto
{
    class cAdisyon
    {
        cGenel gnl = new cGenel();

        #region fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId;
        #endregion

        #region Properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int MasaId
        {
            get { return _MasaId; }
            set { _MasaId = value; }
        }

        public int ServisTurNo
        {
            get { return _ServisTurNo; }
            set { _ServisTurNo = value; }
        }

        public decimal Tutar
        {
            get { return _Tutar; }
            set { _Tutar = value; }
        }

        public DateTime Tarih
        {
            get { return _Tarih; }
            set { _Tarih = value; }
        }

        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }

        public int Durum
        {
            get { return _Durum; }
            set { _Durum = value; }
        }
        #endregion


        public int getByAddition(int MasaId)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From Adisyonlar Where MASAID=@MasaId Order by ID desc", con);

            cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = MasaId;

            try
            {

                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                MasaId = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return MasaId;
        } // açık olan masanın adisyon idsi

    }
}
