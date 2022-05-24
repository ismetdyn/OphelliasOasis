using OphelliasOasis.Common;

namespace OphelliasOasis.Entity
{
    [Table("RezervasyonTip","RezervasyonTipID","RezervasyonTipID")]
    public class RezervasyonTip : BaseEntity<RezervasyonTip>
    {
        [DataObjectField("RezervasyonTipID",true,true,true)]
        public int RezervasyonTipID { get; set; }

        [DataObjectField]
        public string RezervasyonTurAd { get; set; }
    }
}
