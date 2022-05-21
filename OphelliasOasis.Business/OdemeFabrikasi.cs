using OphelliasOasis.Entity.Abstract;
using OphelliasOasis.Entity.Odeme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OphelliasOasis.Business
{
    public class OdemeFabrikasi
    {
        public IOdeme OdemeNesneiOlustur(string odemeTipi)
        {
            if (odemeTipi == "KrediKarti") return new KrediKarti();
            else if(odemeTipi == "Nakit") return new Nakit();
            return null;
        }
    }
}
