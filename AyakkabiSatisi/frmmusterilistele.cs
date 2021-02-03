using OyuncakSatisi.BLL;
using OyuncakSatisi.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyuncakSatisi
{
    public partial class frmmusterilistele : Form
    {
        DataTable dt;
        public frmmusterilistele()
        {
            InitializeComponent();
            datagridmusteriliste.AutoGenerateColumns = false;
        }

        private void frmmusterilistele_Load(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            dt = mbl.MusteriListe();
            datagridmusteriliste.DataSource = dt;
            mbl.Dispose();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            foreach (DataRow item in dt.Rows)
            {
                MODEL.Musteri m = new MODEL.Musteri();
                if (item.RowState != DataRowState.Deleted)
                {
                    m.Musteriad = item["Musteriad"].ToString();
                    m.Musterisoyad = item["Musterisoyad"].ToString();
                    m.Mustericep = item["Mustericep"].ToString();
                    m.Musterimail = item["Musterimail"].ToString();
                    m.Musteriadres = item["Musteriadres"].ToString();
                }
                switch (item.RowState)
                {

                    case DataRowState.Added:
                        mbl.MusteriEkle(m);
                        break;
                    case DataRowState.Deleted:
                        mbl.MusteriSil((int)item["MusteriId", DataRowVersion.Original]);
                        break;
                    case DataRowState.Modified:
                        m.Musteriid = (int)item["MusteriId"];
                        mbl.MusteriGuncelle(m);
                        break;
                    default:
                        break;
                }


            }

        }
    }
}
