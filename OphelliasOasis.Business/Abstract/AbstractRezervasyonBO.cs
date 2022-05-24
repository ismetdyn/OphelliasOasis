using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using OphelliasOasis.ORM;
using System;

namespace OphelliasOasis.Business.Abstract
{
    public abstract class AbstractRezervasyonBO<BO>
        where BO : class, new()
    {
        private static BO _current;

        public static BO Current
        {
            get
            {
                if (_current == null) _current = new BO();
                return _current;
            }
        }

        public virtual Result<Rezervasyon> EkleveGetir(Rezervasyon rezervasyon, Musteri musteri)
        {
            try
            {
                if (musteri != null && musteri.MusteriID == 0)
                {
                    Result<Musteri> result1 = MusteriBO.Current.EkleveGetir(musteri);
                    if (!result1.IsSuccess) throw new Exception(result1.Message);
                    musteri = result1.Data.DeepCopy();
                    rezervasyon.MusteriID = musteri.MusteriID;
                }

                Result<bool> result2 = RezervasyonORM.Current.Insert(rezervasyon);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                Result<Rezervasyon> result3 = RezervasyonORM.Current.GetBy(
                    "MusteriID", musteri.MusteriID.ToString());
                if (!result3.IsSuccess) throw new Exception(result3.Message);
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = string.Format("{0} EkleveGetir başarılı", typeof(BO).Name),
                    Data = result3.Data
                };
            }
            catch (Exception ex)
            {
                return new Result<Rezervasyon>
                {
                    IsSuccess = false,
                    Message = string.Format("Hata(Ekle ve getir başarısız)" + ex.Message)
                };
            }
        }

        public abstract Result<Rezervasyon> RezervasyonYap(Rezervasyon rezervasyon, Musteri musteri, int beklenenDolulukOranı = 100);
        public abstract Result<Rezervasyon> RezervasyonIptal(Rezervasyon rezervasyon, Musteri musteri = null);

        public abstract Result<Rezervasyon> RezervasyonGuncelle(Rezervasyon rezervasyon, Musteri musteri = null);

    }
}
