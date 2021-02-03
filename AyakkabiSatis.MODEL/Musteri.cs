using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiSatisi.MODEL
{
    public class Musteri
    {
        public int Musteriid { get; set; }
        string ad;
        string soyad;
        public string Musteriad { get => ad; set => ad = value.ToUpper(); }
        public string Musterisoyad { get => soyad; set => soyad = value.ToUpper(); }
        public string Mustericep { get; set; }
        public string Musterimail { get; set; }
        public string Musteriadres { get; set; }

    }
}
