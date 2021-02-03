using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiSatisi.MODEL
{
    public class Satis
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public int SatilanUrunAdet { get; set; }
        public float Tutar { get; set; }
        public DateTime TarihSaat { get; set; }
    }
}
