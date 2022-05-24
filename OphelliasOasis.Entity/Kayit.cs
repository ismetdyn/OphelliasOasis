using OphelliasOasis.Common;

namespace OphelliasOasis.Entity
{
    [Table("Kayit","KayitID","KayitID")]
    public class Kayit : BaseEntity<Kayit>
    {
        [DataObjectField("KayitID",true,true,true)]
        public int KayitID { get; set; }

        [DataObjectField]
        public int MusteriID { get; set; }

        [DataObjectField]
        public int RezervasyonID { get; set; }
        
        [DataObjectField]
        public int OdaID { get; set; }
    }
}
