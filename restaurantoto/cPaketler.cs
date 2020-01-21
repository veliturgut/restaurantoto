using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace restaurantoto
{
    class cPaketler
    {
        cGenel gnl = new cGenel();

        #region MyRegion
        private int _ID;
        private int _AdditionID;
        private int _ClientId;
        private string _Description;
        private int _State;
        private int __Paytypeid;
        #endregion


        #region Properties
        public int _Paytypeid
        {
            get { return __Paytypeid; }
            set { __Paytypeid = value; }
        }

        public int State
        {
            get { return _State; }
            set { _State = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public int ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }

        public int AdditionID
        {
            get { return _AdditionID; }
            set { _AdditionID = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        #endregion

        //paket servisi Açma
        public bool OrderServiceOpen(cPaketler order)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into paketSiparis(ADISYONID,MUSTERIID,ODEMETURID,ACIKLAMA) " +
                "values(@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA) ", con);


            try
            {

                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = order._AdditionID;
                cmd.Parameters.Add("@MUSTERIID", SqlDbType.Int).Value = order._ClientId;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = order.__Paytypeid;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order._Description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch(Exception ex)
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

        //Paket Servisi kapatma
        public void OrderServiceClose(int AdditionID)
        {
            

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update paketSiparis set paketSiparis.durum = 1 from paketSiparis Inner Join adisyonlar " +
                "on paketSiparis.ADISYONID=adisyonlar.ID where paketSiparis.ADISYONID=@AdditionID ", con);


            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@AdditionID", SqlDbType.Int).Value = AdditionID;
               
                Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

           
        }


        public int GetPayTypeId(int adisyonid)
        {
            int PayTypeID = 0;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.ODEMETURID from paketSiparis Inner Join Adisyonlar on " +
                "paketSiparis.ADISYONID=Adisyonlar.ID where adisyonlar.ID = @adisyonid", con);


            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@adisyonid", SqlDbType.Int).Value = adisyonid;
                 
                PayTypeID = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

            return PayTypeID;

        }

        public int GetCustomerlAdditionID(int customerID)
        {
            int no = 0;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select adisyonlar.ID from adisyonlar Inner Join paketSiparis on " +
                "paketSiparis.ADISYONID=Adisyonlar.ID where (adisyonlar.DURUM=0) and (paketSiparis.DURUM=0) and paketSiparis.MUSTERIID=@customerID", con);


            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;

                no = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }


            return no;
        }


        public bool getCheckOpenAdditionID(int additionID)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from adisyonlar where (DURUM=0) and (ID=@additionID)", con);


            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@additionID", SqlDbType.Int).Value = additionID;
                
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (Exception ex)
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
    }
}
