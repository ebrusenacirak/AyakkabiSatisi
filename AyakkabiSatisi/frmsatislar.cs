using AyakkabiSatisi.BLL;
using OAyakkabiSatisi.MODEL;
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
    public partial class frmsatislar : Form
    {
        public frmsatislar()
        {
            InitializeComponent();
        }

        private void frmsatislar_Load(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            UrunBL ubl = new UrunBL();
            int[] Satisadet = { 1, 2, 3, 4, 5 };
            cmbxadet.DataSource = Satisadet;
            cmbxurun.DisplayMember = "Urunadi";
            cmbxurun.ValueMember = "UrunId";
            cmbxurun.DataSource = ubl.UrunListesi();
            cmbxmusteri.DisplayMember = "Musteriad";
            cmbxmusteri.ValueMember = "MusteriId";
            cmbxmusteri.DataSource = mbl.MusteriListe();
            mbl.Dispose();
            ubl.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunBL ubl = new UrunBL();
            SatisBL sbl = new SatisBL();
            Satis sts = new Satis();
            sts.MusteriId = (int)cmbxmusteri.SelectedValue;
            sts.UrunId = (int)cmbxurun.SelectedValue;
            sts.TarihSaat = DateTime.Now;
            sts.SatilanUrunAdet = (int)cmbxadet.SelectedValue;
            sts.Tutar = ubl.FiyatBul((int)cmbxurun.SelectedValue) * (int)cmbxadet.SelectedValue;
            if (sbl.SatisYap(sts))
            {
                MessageBox.Show("Başarılı");
            }
            sbl.Dispose();
            ubl.Dispose();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
