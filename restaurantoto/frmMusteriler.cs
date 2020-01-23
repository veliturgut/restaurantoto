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
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();

            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            MusteriEkleme m = new MusteriEkleme();
            cGenel._musteriEkleme = 1;
            m.Show();

        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musterileriGetir(lvMusteriler);
        }

        private void btnMusteriSec_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (lvMusteriler.SelectedItems.Count > 0)
            {
                MusteriEkleme frm = new MusteriEkleme();
                cGenel._musteriEkleme = 1;
                cGenel._musteriId = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);

                
                this.Close();
                frm.Show();
            }

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
    }
}
