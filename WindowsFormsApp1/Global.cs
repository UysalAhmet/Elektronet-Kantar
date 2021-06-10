using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Global
    {
        public static WindowsFormsApp1Entities db = new WindowsFormsApp1Entities(/*Properties.Settings.Default.KantarDbConnectionString*/);
        public static List<Yetkili> kullanicilar = db.Yetkili.ToList();
        public static bool basarili=false;
        public static bool kullaniciGiris=false;
        public static  Yetkili Kullanici=null;
        public static string lisanskey;
        public static Arac sonarac;
        public static Malzeme sonmalzeme;
        public static CariUnvan_Firma sonfirma;
        public static SevkYeri sonsevkyeri;
        public static Sofor sonsofor;
        
        public static bool Login(Yetkili yetkili)
        {
            var user = kullanicilar.FirstOrDefault(x => x.YetkiliKullaniciAd == yetkili.YetkiliKullaniciAd && x.YetkiliSifre == yetkili.YetkiliSifre);
            if (user != null)
            {
                if (Kullanici == null)
                {
                    Kullanici = user;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
