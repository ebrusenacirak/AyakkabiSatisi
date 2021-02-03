using AyakkabiSatisi.DAL;
using AyakkabiSatisi.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiSatisi.BLL
{
    public class SatisBL : IDisposable
    {
        Helper hlp = new Helper();

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }

        public bool SatisYap(Satis s)
        {
            UrunBL ubl = new UrunBL();
            SqlParameter[] p = {new SqlParameter("@MusteriId",s.MusteriId), new SqlParameter("@UrunId",s.UrunId),
            new SqlParameter("@SatilanUrunAdet",s.SatilanUrunAdet),new SqlParameter("Tutar",s.Tutar), new SqlParameter("@TarihSaat",s.TarihSaat)};
            int sonuc = hlp.ExecuteNonQuery("Insert into tblSatislar values (@UrunId,@MusteriId,@SatilanUrunAdet,@Tutar,@TarihSaat)", p);
            int stok = ubl.StokBul(s.UrunId);
            stok = stok - s.SatilanUrunAdet;

            SqlParameter[] p1 = { new SqlParameter("@Stok", stok), new SqlParameter("@UrunId", s.UrunId) };
            int sonuc1 = hlp.ExecuteNonQuery("Update tblUrun set Stok=@Stok where UrunId=@UrunId", p1);
            return sonuc > 0 && sonuc1 > 0;
        }

    }

}
