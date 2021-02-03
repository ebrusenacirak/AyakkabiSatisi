using AyakkabiSatisi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyakkabiSatisi.MODEL;
using System.Data.SqlClient;
using System.Data;

namespace AyakkabiSatisi.BLL
{
    public class UrunBL : IDisposable
    {
        Helper hlp = new Helper();
        float fiyat;
        int stok;

        public List<Urun> UrunListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select UrunId, Urunadi, KategoriId, Urunfiyat, Stok from tblUrun", null);
            List<Urun> lst = new List<Urun>();
            while (dr.Read())
            {
                Urun u = new Urun();
                u.Urunadi = dr["Urunadi"].ToString();
                u.Urunfiyat = float.Parse(dr["Urunfiyat"].ToString());
                u.UrunId = Convert.ToInt32(dr["UrunId"]);
                u.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                u.Stok = Convert.ToInt32(dr["Stok"]);

                lst.Add(u);
            }
            dr.Close();
            return lst;
        }
        public bool UrunEkle(Urun u)
        {
            SqlParameter[] p = { new SqlParameter("@Urunadi", u.Urunadi), new SqlParameter("@Urunfiyat", u.Urunfiyat), new SqlParameter("@KategoriId", u.KategoriId), new SqlParameter("@Stok", u.Stok) };
            return hlp.ExecuteNonQuery("Insert into tblUrun values (@Urunadi,@KategoriId,@Urunfiyat,@Stok)", p) > 0;
        }
        public bool UrunSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@UrunId", id) };
            return hlp.ExecuteNonQuery("Delete from tblUrun where UrunId = @UrunId", p) > 0;
        }
        public DataTable UrunTablosu()
        {
            return hlp.MyDataTable("Select u.UrunId, u.Urunadi, u.KategoriId, u.Stok, k.Kategoriadi from tblUrun u inner join tblKategori k on k.KategoriId = u.KategoriId");
        }
        public float FiyatBul(int id)
        {
            SqlParameter[] p = { new SqlParameter("@Id", id) };
            SqlDataReader dr = hlp.ExecuteReader("Select Urunfiyat from tblUrun where UrunId=@Id", p);
            if (dr.Read())
            {
                fiyat = float.Parse(dr["Urunfiyat"].ToString());
            }
            return fiyat;
        }
        public int StokBul(int id)
        {
            SqlParameter[] p = { new SqlParameter("@Id", id) };
            SqlDataReader dr = hlp.ExecuteReader("Select Stok from tblUrun where UrunId=@Id", p);
            if (dr.Read())
            {
                stok = int.Parse(dr["Stok"].ToString());
            }
            return stok;

        }
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }

    }
}
