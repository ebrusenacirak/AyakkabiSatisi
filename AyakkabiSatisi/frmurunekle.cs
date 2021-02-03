using AyakkabiSatisi.BLL;
using AyakkabiSatisi.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyakkabiSatisi
{
    public partial class frmurunekle : Form
    {
        public frmurunekle()
        {
            InitializeComponent();
        }

        private void frmurunekle_Load(object sender, EventArgs e)
        {
            KategoriBL kbl = new KategoriBL();
            cmbxkategori.DisplayMember = "Kategoriadi";
            cmbxkategori.ValueMember = "KategoriId";
            cmbxkategori.DataSource = kbl.KategoriListe();
            kbl.Dispose();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            UrunBL ubl = new UrunBL();
            Urun u = new Urun();
            u.Urunadi = txturunad.Text.Trim();
            u.Urunfiyat = float.Parse(txtfiyat.Text.Trim());
            u.Stok = Convert.ToInt32(txtstok.Text.Trim());
            u.KategoriId = Convert.ToInt32(cmbxkategori.SelectedValue);
            if (ubl.UrunEkle(u))
            {
                MessageBox.Show("Ürün ekleme başarılı.");
            }
            else
            {
                MessageBox.Show("Ürün ekleme başarısız.");
            }
            ubl.Dispose();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            frmUrunListele frm = new frmUrunListele();
            frm.Show();
        }


    }
}
