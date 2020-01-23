using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantoto
{
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtTelefon.Text.Length > 6 )
            {
                if (txtMusteriAd.Text == " " || txtMusteriSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen Müşterinin Ad ve Soyad Alanlarını doldurunuz.");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    bool result = c.MusteriVarmi(txtTelefon.Text);

                    if (!result)
                    {

                        c.Musteriad = txtMusteriAd.Text;
                        c.Musterisoyad = txtMusteriSoyad.Text;
                        c.Telefon = txtTelefon.Text;
                        c.Email = txtEmail.Text;
                        c.Adres = txtAdres.Text;
                        txtMusteriNo.Text =  c.musteriEkle(c).ToString();

                        if (txtMusteriNo.Text != "" )
                        {

                            MessageBox.Show("Müşteri eklendi.");

                        }
                        else
                        {
                            MessageBox.Show("Müşteri eklenemedi!!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde bir kayıt var!!!");
                    }


                }


            }
            else
            {
                MessageBox.Show("Lütfen En az 7 haneli bir telefon numarası giriniz.");
            }

        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {

            if (cGenel._musteriEkleme == 0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                cGenel._musteriEkleme = 1;
                this.Close();
                frm.Show();
            }
            else if (cGenel._musteriEkleme == 1)
            {
                frmPaketSiparis frm = new frmPaketSiparis();          
                cGenel._musteriEkleme = 0;
                this.Close();
                frm.Show();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (txtTelefon.Text.Length > 6)
            {
                if (txtMusteriAd.Text == " " || txtMusteriSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen Müşterinin Ad ve Soyad Alanlarını doldurunuz.");
                }
                else
                {
                    cMusteriler c = new cMusteriler();

                    c.Musteriad = txtMusteriAd.Text;
                    c.Musterisoyad = txtMusteriSoyad.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Email = txtEmail.Text;
                    c.Adres = txtAdres.Text;
                    c.Musteriid = Convert.ToInt32(txtMusteriNo.Text);
                    bool result = c.musteriBilgileriGüncelle(c);
                    

                    if (!result)
                    {

                       

                        if (txtMusteriNo.Text != "")
                        {

                            MessageBox.Show("Müşteri güncellendi");

                        }
                        else
                        {
                            MessageBox.Show("Müşteri güncellenemedi!!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bu isimde bir kayıt var!!!");
                    }


                }


            }
            else
            {
                MessageBox.Show("Lütfen En az 7 haneli bir telefon numarası giriniz.");
            }

        }
    }
}
