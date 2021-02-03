using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiSatisi.MODEL
{
    public class Urun
    {
        public int UrunId { get; set; }

        public int KategoriId { get; set; }
        public string Urunadi { get; set; }
        public float Urunfiyat { get; set; }
        public int Stok { get; set; }
    }
}
