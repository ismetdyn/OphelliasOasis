using OphelliasOasis.Common;

namespace OphelliasOasis.Entity
{
    [Table("Musteri","MusteriID","MusteriID")]
    public class Musteri : BaseEntity<Musteri>
    {
        [DataObjectField("MusteriID",true,true,true)]
        public int MusteriID { get; set; }

        [DataObjectField("MusteriAd", true, false, false, true)]
        public string MusteriAd { get; set; }

        [DataObjectField]
        public string MusteriSoyad { get; set; }
        
        [DataObjectField]
        public string MusteriEposta { get; set; }

        [DataObjectField]
        public bool KartBilgi { get; set; }

        [DataObjectField]
        public bool GercekMusteri { get; set; }
    }
}
