using OphelliasOasis.Common;

namespace OphelliasOasis.Entity
{
    [Table("Oda","OdaID","OdaID")]
    public class Oda : BaseEntity<Oda>
    {
        [DataObjectField("OdaID",true,true,true)]
        public int OdaID { get; set; }

        [DataObjectField]
        public bool BosMu { get; set; }

        [DataObjectField]
        public decimal TabanFiyat { get; set; }
    }
}
