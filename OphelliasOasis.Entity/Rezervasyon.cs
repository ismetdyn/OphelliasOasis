using OphelliasOasis.Common;
using System;

namespace OphelliasOasis.Entity
{
    [Table("Rezervasyon", "RezervasyonID", "RezervasyonID")]
    public class Rezervasyon : BaseEntity<Rezervasyon>
    {
        [DataObjectField("RezervasyonID", true, true, true ,false)]
        public int RezervasyonID { get; set; }

        [DataObjectField]
        public int MusteriID { get; set; }

        [DataObjectField]
        public int RezervasyonTipID { get; set; }

        [DataObjectField]
        public DateTime RezervasyonTalepTarihi { get; set; }

        [DataObjectField]
        public DateTime RezervasyonBaslangicTarihi { get; set; }

        [DataObjectField]
        public DateTime RezervasyonBitisTarihi { get; set; }

        [DataObjectField]
        public decimal Fiyat { get; set; }

        [DataObjectField]
        public DateTime OdemeTarih { get; set; }

        [DataObjectField]
        public bool AktifMi { get; set; }

        [DataObjectField]
        public DateTime CheckIn { get; set; }

        [DataObjectField]
        public DateTime Checkout { get; set; }

        [DataObjectField]
        public bool OdemeOnay { get; set; }
    }
}
