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
    public partial class frmUrunListele : Form
    {
        DataTable dt;
        public frmUrunListele()
        {
            InitializeComponent();
            datagridurunliste.AutoGenerateColumns = false;
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            KategoriBL kbl = new KategoriBL();
            clmkategori.DisplayMember = "Kategoriadi";
            clmkategori.ValueMember = "KategoriId";
            clmkategori.DataSource = kbl.KategoriListe();

            UrunBL ubl = new UrunBL();
            dt = ubl.UrunTablosu();
            datagridurunliste.DataSource = dt;

            kbl.Dispose();
            ubl.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunBL ubl = new UrunBL();
            foreach (DataRow item in dt.Rows)
            {
                Urun u = new Urun();
                if (item.RowState != DataRowState.Deleted)
                {
                    u.Urunadi = item["Urunadi"].ToString();
                    u.KategoriId = Convert.ToInt32(item["KategoriId"]);
                    u.UrunId = Convert.ToInt32(item["UrunId"]);
                    u.Stok = Convert.ToInt32(item["Stok"]);
                    u.Urunfiyat = float.Parse(item["Urunfiyati"].ToString());
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ubl.UrunEkle(u);
                        break;
                    case DataRowState.Deleted:
                        ubl.UrunSil((int)item["UrunId", DataRowVersion.Original]);
                        break;
                    case DataRowState.Modified:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
