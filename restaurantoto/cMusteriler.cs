using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace restaurantoto
{
    class cMusteriler
    {

        cGenel gnl = new cGenel();

        #region Fields
        private int _musteriid;
        private string _musteriad;
        private string _musterisoyad;
        private string _telefon;
        private string _adres;
        private string _email;
        #endregion

        #region Properties
        
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Musteriid
        {
            get { return _musteriid; }
            set { _musteriid = value; }
        }

        public string Musteriad
        {
            get { return _musteriad; }
            set { _musteriad = value; }
        }

        public string Musterisoyad
        {
            get { return _musterisoyad; }
            set { _musterisoyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        #endregion


        public bool MusteriVarmi(string tlf)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "MusteriVarmi";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", SqlDbType.Int);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            try
            {

                cmd.ExecuteNonQuery();
                result = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                
                con.Close();
            }


            return false;
        }


        public int musteriEkle(cMusteriler m)
        {
            int result = 0;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into musteriler(AD,SOYAD,TELEFON,ADRES,EMAIL) " +
                "values(@ad,@soyad,@telefon,@adres,@email); select SCOPE_IDENTITY()", con);

            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musterisoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value =m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;  
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
                result = Convert.ToInt32(cmd.ExecuteScalar());
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

        public bool musteriBilgileriGüncelle(cMusteriler m)
        {
            bool result = false;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update musteriler set AD=@ad,SOYAD=@soyad,TELEFON=@telefon,ADRES=@adres,EMAIL=@email where ID=@musteriId ", con);

            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = m._musteriad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = m._musterisoyad;
                cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._email;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = m._musteriid;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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


        public void musterileriGetir(ListView lv)
        {

            lv.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from musteriler",con);

            SqlDataReader dr = null;

            


            try
            {

                if (con.State == ConnectionState.Closed)
                {
                     con.Open();
                }

                dr = cmd.ExecuteReader();

                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["ID"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["AD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["SOYAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["TELEFON"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADRES"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["EMAIL"].ToString());
                    sayac++;
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
        }
    }
}
