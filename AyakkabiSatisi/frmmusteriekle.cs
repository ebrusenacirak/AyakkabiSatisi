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
    public partial class frmmusteriekle : Form
    {
        public int musteriid = 0;
        public frmmusteriekle()
        {
            InitializeComponent();
        }
        public frmmusteriekle(Form1 f)
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            try
            {
                tblMusteri musteri = new tblMusteri();
                musteri.Musteriad = txtad.Text.Trim();
                musteri.Musterisoyad = txtsoyad.Text.Trim();
                musteri.Mustericep = txtcep.Text.Trim();
                musteri.Musterimail = txtmail.Text.Trim();
                musteri.Musteriadres = txtadres.Text.Trim();
                musteri.MusteriId = musteriid;

                if (musteriid == 0)
                {
                    if (mbl.MusteriKayit(musteri))
                    {
                        MessageBox.Show("Ekleme Başarılı");
                    }
                }
                else
                {
                    MessageBox.Show(mbl.MusteriYenile(musteri) ? "Başarılı" : "Başarısız");
                    musteriid = 0;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Bir hata oluştu..");
                throw;
            }
            finally
            {
                Temizle();
                mbl.Dispose();
            }
        }

        void Temizle()
        {
            foreach (Control item in this.Controls["pnltextbox"].Controls)
            {
                item.Text = string.Empty;
            }
            musteriid = 0;
            btnvazgec.Visible = false;
            btnekle.Text = "Ekle";
            btnsil.Visible = false;

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cvp == DialogResult.No) return;

            MusteriBL mbl = new MusteriBL();
            try
            {
                if (mbl.MusteriSil(musteriid))
                {
                    MessageBox.Show("Silme Başarılı'");
                }
                else
                {
                    MessageBox.Show("Silme Hatalı!!");
                }
                Temizle();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mbl.Dispose();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriAra frm = new frmMusteriAra(this);
            frm.Show();
        }

        private void btnmusterilistele_Click(object sender, EventArgs e)
        {
            frmmusterilistele frm = new frmmusterilistele();
            frm.Show();
        }
    }
}
