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

    }
}
