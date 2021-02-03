using AyakkabiSatisi.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiSatisi.BLL
{
    public class KategoriBL : IDisposable
    {
        Helper hlp = new Helper();
        List<MODEL.Kategori> lst;

        public bool KategoriEkle(MODEL.Kategori k)
        {
            SqlParameter[] p = { new SqlParameter("@Kategoriadi", k.Kategoriadi) };
            return hlp.ExecuteNonQuery("Insert into tblKategori values (@Kategoriadi)", p) > 0;
        }
        public DataTable KategoriListe()
        {
            return hlp.MyDataTable("Select KategoriId,Kategoriadi from tblKategori");
            //while (dr.Read())
            //{
            //    lst = new List<MODEL.Kategori>();
            //    MODEL.Kategori k = new MODEL.Kategori();
            //    k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
            //    k.Kategoriadi = dr["Kategoriadi"].ToString();
            //    lst.Add(k);
            //}
            //dr.Close();
            //return lst;
        }
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
