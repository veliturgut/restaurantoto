using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace restaurantoto
{
    class cRezervasyon
    {
        cGenel gnl = new cGenel();

        #region Fields

        private int _ID;
        private int _TableId;
        private int _ClientId;
        private DateTime _Date;
        private int _ClientCount;
        private string _Description;
        private int _AdditionId;
        #endregion

        #region Properties
        public int TableId
        {
            get { return _TableId; }
            set { _TableId = value; }
        }

        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public int AdditionId
        {
            get { return _AdditionId; }
            set { _AdditionId = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int ClientCount
        {
            get { return _ClientCount; }
            set { _ClientCount = value; }
        }
        #endregion



        public int getByClientIdFromReservation(int tableId)
        {
            int clientId = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 MUSTERIID from Rezervasyonlar where MASAID=@masaid order by MUSTERIID Desc", con);

            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("masaid", SqlDbType.Int).Value = tableId;
                

                clientId = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                con.Dispose();
                con.Close();
            }



            return clientId;
        }


        public bool reservationClose(int AdditionID)
        {
            bool result = false;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update Rezervasyonlar set durum = 0 where ADISYONID=@adisyonId", con);
             
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = AdditionId;

                result = Convert.ToBoolean(cmd.ExecuteScalar());
               
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }



            return result;
        }
    }
}
