using AyakkabiSatisi.DAL;
using AyakkabiSatisi.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyakkabiSatisi.BLL
{
    public class MusteriBL : IDisposable
    {
        Helper hlp = new Helper();

        public bool MusteriEkle(MODEL.Musteri mstr)
        {
            SqlParameter[] p = { new SqlParameter("@Musteriad", mstr.Musteriad), new SqlParameter("@Musterisoyad", mstr.Musterisoyad), new SqlParameter("@Mustericep", mstr.Mustericep), new SqlParameter("@Musterimail", mstr.Musterimail), new SqlParameter("@Musteriadres", mstr.Musteriadres) };
            int sonuc = hlp.ExecuteNonQuery("Insert into tblMusteri values(@Musteriad,@Musterisoyad,@Mustericep,@Musterimail,@Musteriadres)", p);
            return sonuc > 0;
        }
        public bool MusteriKayit(tblMusteri mstr)
        {
            using (SiparisContext ctx = new SiparisContext())
            {
                ctx.tblMusteris.Add(new tblMusteri
                {
                    Musteriad = mstr.Musteriad,
                    Musterisoyad = mstr.Musterisoyad,
                    Musteriadres = mstr.Musteriadres,
                    Mustericep = mstr.Mustericep,
                    Musterimail = mstr.Musterimail
                });
                ctx.SaveChanges();
                return true;
            }
        }

        public bool MusteriGuncelle(MODEL.Musteri mstr)
        {
            SqlParameter[] p = { new SqlParameter("@MusteriId", mstr.Musteriid), new SqlParameter("@Musteriad", mstr.Musteriad), new SqlParameter("@Musterisoyad", mstr.Musterisoyad), new SqlParameter("@Mustericep", mstr.Mustericep), new SqlParameter("@Musterimail", mstr.Musterimail), new SqlParameter("@Musteriadres", mstr.Musteriadres) };
            int sonuc = hlp.ExecuteNonQuery("Update tblMusteri set Musteriad=@Musteriad,Musterisoyad=@Musterisoyad,Mustericep=@Mustericep,Musterimail=@Musterimail,Musteriadres=@Musteriadres where MusteriId=@MusteriId", p);
            return sonuc > 0;
        }
        public bool MusteriYenile(tblMusteri mstr)
        {
            using (SiparisContext ctx = new SiparisContext())
            {
                tblMusteri m = ctx.tblMusteris.Find(mstr.MusteriId);
                m.Musteriad = mstr.Musteriad;
                m.Musterisoyad = mstr.Musterisoyad;
                m.Musteriadres = mstr.Musteriadres;
                m.Musterimail = mstr.Musterimail;
                m.Mustericep = mstr.Mustericep;
                ctx.SaveChanges();
            }
            return true;
        }

        public bool MusteriSil(int musteriıd)
        {
            SqlParameter[] p = { new SqlParameter("@MusteriId", musteriıd) };
            return hlp.ExecuteNonQuery("Delete from tblMusteri where MusteriId=@MusteriId", p) > 0;
        }



        public Musteri MusteriBul(string mCep)
        {
            SqlParameter[] p = { new SqlParameter("@Mustericep", mCep) };
            SqlDataReader dr = hlp.ExecuteReader("Select * from tblMusteri where Mustericep=@Mustericep", p);
            Musteri m = null;
            if (dr.Read())
            {
                m = new Musteri();
                m.Musteriad = dr["Musteriad"].ToString();
                m.Musterisoyad = dr["Musterisoyad"].ToString();
                m.Mustericep = dr["Mustericep"].ToString();
                m.Musterimail = dr["Musterimail"].ToString();
                m.Musteriadres = dr["Musteriadres"].ToString();
                m.Musteriid = Convert.ToInt32(dr["MusteriId"]);
            }

            dr.Close();

            return m;
        }

        public DataTable MusteriListe()
        {
            return hlp.MyDataTable("Select * from tblMusteri");
        }
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
