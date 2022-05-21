using System;

namespace OphelliasOasis.Entity.Abstract
{
    public abstract class AbstractRezervasyon
    {
        public int RezervasyonID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int RezervasyonTipi { get; set; }

        public IOdeme Odeme { get; set; }
    }
}
