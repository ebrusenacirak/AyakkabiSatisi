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
    public partial class frmKategoriEkle : Form
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            MODEL.Kategori k = new MODEL.Kategori();
            KategoriBL kbl = new KategoriBL();
            if (txtkat.Text == String.Empty)
            {
                return;
            }
            k.Kategoriadi = txtkat.Text.Trim();
            if (kbl.KategoriEkle(k))
            {
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Eklenirken hata oluştu!");
            }
            kbl.Dispose();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
