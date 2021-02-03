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
    public partial class frmMusteriAra : Form
    {
        private frmmusteriekle form1;
        public frmMusteriAra()
        {
            InitializeComponent();
        }
        public frmMusteriAra(frmmusteriekle f)
        {
            this.form1 = f;
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            MusteriBL mbl = new MusteriBL();
            Musteri mstr = mbl.MusteriBul(txtmustericep.Text);

            if (mstr == null)
            {
                MessageBox.Show("Müşteri Bulunamadı!");
            }
            else
            {
                form1.musteriid = mstr.Musteriid;
                form1.txtad.Text = mstr.Musteriad;
                form1.txtsoyad.Text = mstr.Musterisoyad;
                form1.txtcep.Text = mstr.Mustericep;
                form1.txtadres.Text = mstr.Musteriadres;
                form1.txtmail.Text = mstr.Musterimail;
                form1.btnvazgec.Visible = true;
                form1.btnekle.Text = "Güncelle";
                form1.btnsil.Visible = true;
                this.Visible = false;

            }
        }

        private void frmMusteriAra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
