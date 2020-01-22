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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();

            this.Close();
            frm.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        cSiparis cs = new cSiparis();
        int PayTypeId = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            gbIndirim.Visible = false;
            if(cGenel._ServisTurNo == 1)
            {

                lblAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));

                if(lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;

                    for(int i=0; i < lvUrunler.Items.Count; i++)
                    {

                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }

                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }

                txtIndirimTutari.Clear();
            }
            else if(cGenel._ServisTurNo == 2)
            {

                lblAdisyonId.Text = cGenel._AdisyonId;
                cPaketler pc = new cPaketler();
                PayTypeId = pc.GetPayTypeId(Convert.ToInt32(lblAdisyonId.Text));

                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonId.Text));

                if(PayTypeId == 1)
                {
                    rbKrediKarti.Checked = true;
                }
                else if(PayTypeId == 2)
                {
                    rbNakit.Checked = true;
                }
                else if (PayTypeId == 3)
                {
                    rbTicket.Checked = true;
                }

                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;

                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {

                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }

                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }

                txtIndirimTutari.Clear();

            }
        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {

                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutari.Text));
                    }
                    catch (Exception)
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }

                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz !!!");
                }


            }
            catch (Exception)
            {
                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }


        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }

            decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18/100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);
        }

        cRezervasyon rezerve = new cRezervasyon();
        cMasalar masalar = new cMasalar();

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo == 1)
            {
                int tableid = masalar.TableGetbyNumber(cGenel._ButtonName);
                int customerId = 0;

                if (masalar.TableGetbyState(tableid,4) == true)
                {
                    customerId = rezerve.getByClientIdFromReservation(tableid);

                }
                else
                {
                    customerId = 1;
                }


                int payTypeId = 0;

                if (rbNakit.Checked)
                {
                    payTypeId = 1;
                }
                if (rbKrediKarti.Checked)
                {
                    payTypeId = 2;
                }
                if (rbTicket.Checked)
                {
                    payTypeId = 3;
                }


                cOdeme odeme = new cOdeme();

                odeme.AdisyonID = Convert.ToInt32(lblAdisyonId.Text);
                odeme.OdemeTurId = PayTypeId;
                odeme.MusteriId = customerId;
                odeme.AraToplam = Convert.ToInt32(lblOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);

                if (result)
                {

                    MessageBox.Show("Hesap kapatılmıştır.");
                    masalar.setChangeTableState(Convert.ToString(tableid), 1);

                    cRezervasyon c = new cRezervasyon();
                    c.reservationClose(Convert.ToInt32(lblAdisyonId.Text));

                    cAdisyon a = new cAdisyon();
                    a.additionClose(Convert.ToInt32(lblAdisyonId.Text), 0);

                    this.Close();

                    frmMasalar frm = new frmMasalar();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken bir hata oluştu.");
                }


            }
        }

        private void btnHesapOzet_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("xxxx RESTAURANT", Baslik, sb, 350,100, st);
            
            e.Graphics.DrawString("-----------------", altBaslik, sb, 350,120, st);
            e.Graphics.DrawString("Ürün Adı                Adet        Fiyat", altBaslik, sb, 150,250, st);
            e.Graphics.DrawString("----------------------------------------------", altBaslik, sb, 150,280, st);

            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[1].SubItems[0].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[3].SubItems[0].Text, icerik, sb, 420, 300 + i * 30, st);

            }

            e.Graphics.DrawString("---------------------------------------------------", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı   :-------------------"+ lblIndirim.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count +1), st);
            e.Graphics.DrawString("KDV Tutarı       :-------------------"+ lblKdv.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count +2), st);
            e.Graphics.DrawString("Toplam Tutarı    :-------------------"+ lblToplamTutar.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count +3), st);
            e.Graphics.DrawString("Ödediğiniz Tutar :-------------------"+ lblOdenecek.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count +4), st);
            



        }
    }
}
