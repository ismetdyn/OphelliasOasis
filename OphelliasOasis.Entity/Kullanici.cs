using System;
using OphelliasOasis.Common;

namespace OphelliasOasis.Entity
{
    [Table("Kullanicilar", "KullaniciID", "KullaniciID", "KullaniciAdi")]
    public class Kullanici : IDisposable
    {
        [DataObjectField("KullaniciID", true, true, true, false)]
        public int KullaniciID { get; set; }

        [DataObjectField("KullaniciAdi", true, false, false, true)]
        public string KullaniciAdi { get; set; }

        [DataObjectField]
        public string Ad { get; set; }

        [DataObjectField]
        public string Soyad { get; set; }

        [DataObjectField]
        public string Eposta { get; set; }

        [DataObjectField]
        public string Sifre { get; set; }

        [DataObjectField]
        public int KullaniciTipID { get; set; }

        public Kullanici DeepCopy()
        {
            return (Kullanici)MemberwiseClone();
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
