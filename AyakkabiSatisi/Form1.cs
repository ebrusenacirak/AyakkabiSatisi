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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            frmmusteriekle frm = new frmmusteriekle(this);
            frm.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            frmKategoriEkle frm = new frmKategoriEkle();
            frm.Show();
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            frmurunekle frm = new frmurunekle();
            frm.Show();
        }

        private void btnsatıslar_Click(object sender, EventArgs e)
        {
            frmsatislar frm = new frmsatislar();
            frm.Show();

        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
