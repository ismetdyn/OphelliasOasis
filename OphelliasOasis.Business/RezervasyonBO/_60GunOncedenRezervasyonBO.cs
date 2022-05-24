using OphelliasOasis.Business.Abstract;
using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using OphelliasOasis.ORM;
using System;

namespace OphelliasOasis.Business.RezervasyonBO
{
    public class _60GunOncedenRezervasyonBO : AbstractRezervasyonBO<_60GunOncedenRezervasyonBO>
    {
        public override Result<Rezervasyon> RezervasyonYap(
            Rezervasyon rezervasyon, 
            Musteri musteri,
            int beklenenDolulukOranı)
        {
            try
            {
                if (DateTime.Now.AddDays(60) >
                    rezervasyon.RezervasyonBaslangicTarihi)
                    throw new Exception("Rezervasyon a 60 günden az var");
                if (musteri.MusteriEposta == null) throw new Exception(
                    "Bu rezervasyon türünde eposta gereklidir.");
                Result<Oda> result1 = OdaORM.Current.GetByID(1);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                int gunSayisi = (int)(rezervasyon.RezervasyonBitisTarihi -
                    rezervasyon.RezervasyonBaslangicTarihi).TotalDays;
                rezervasyon.Fiyat = gunSayisi * result1.Data.TabanFiyat * 85 / 100;
                rezervasyon.RezervasyonTipID = 2;
                rezervasyon.RezervasyonTalepTarihi = DateTime.Now;
                rezervasyon.OdemeOnay = false;
                Result<Rezervasyon> result2 = EkleveGetir(rezervasyon, musteri);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = "On Odemeli rezervasyon başarıyla iptal edildi",
                    Data = result2.Data,
                };
            }
            catch (Exception ex)
            {
                return new Result<Rezervasyon>
                {
                    IsSuccess = false,
                    Message = "Hata!(RezervasyonYap)" + ex.Message
                };
            }
        }

        public override Result<Rezervasyon> RezervasyonGuncelle(
            Rezervasyon rezervasyon = null, Musteri musteri = null)
        {
            try
            {
                if(rezervasyon == null)
                {
                    Result<Musteri> result1 =
                        MusteriORM.Current.GetBy("MusteriAd", musteri.MusteriAd);
                    if (!result1.IsSuccess) throw new Exception(result1.Message);
                    Result<Rezervasyon> result2 =
                        RezervasyonORM.Current.GetBy("MusteriID", result1.Data.MusteriID.ToString());
                    if (!result2.IsSuccess) throw new Exception(result2.Message);
                    rezervasyon = result2.Data.DeepCopy();
                }
                else
                {
                    Result<Rezervasyon> result3 =
                         RezervasyonORM.Current.GetByID(rezervasyon.RezervasyonID);
                    if (!result3.IsSuccess) throw new Exception(result3.Message);
                    rezervasyon = result3.Data.DeepCopy();
                }
                Result<Oda> resultOda = OdaORM.Current.GetByID(1);
                if (!resultOda.IsSuccess) throw new Exception(resultOda.Message);
                decimal Fiyat = resultOda.Data.TabanFiyat;
                if (Fiyat * 21 / 100 > rezervasyon.Fiyat) rezervasyon.Fiyat = Fiyat;
                Result<bool> result4 = RezervasyonORM.Current.Update(rezervasyon);
                if (!result4.IsSuccess) throw new Exception(result4.Message);
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = "Rezervayon Guncelleme başarılı",
                    Data = rezervasyon
                };
            }
            catch (Exception ex)
            {
                return new Result<Rezervasyon>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public override Result<Rezervasyon> RezervasyonIptal(
            Rezervasyon rezervasyon = null, 
            Musteri musteri = null)
        {
            try
            {
                if (rezervasyon == null)
                {
                    Result<Musteri> result1 =
                        MusteriORM.Current.GetBy("MusteriAd", musteri.MusteriAd);
                    if (!result1.IsSuccess) throw new Exception(result1.Message);
                    musteri = result1.Data.DeepCopy();
                    Result<Rezervasyon> result2 =
                        RezervasyonORM.Current.GetBy("MusteriID", result1.Data.MusteriID.ToString());
                    if (!result2.IsSuccess) throw new Exception(result2.Message);
                    rezervasyon = result2.Data.DeepCopy();
                }
                else
                {
                    Result<Rezervasyon> result3 =
                         RezervasyonORM.Current.GetByID(rezervasyon.RezervasyonID);
                    if (!result3.IsSuccess) throw new Exception(result3.Message);
                    rezervasyon = result3.Data.DeepCopy();
                }
                Result<bool> result4 = RezervasyonORM.Current.Delete(rezervasyon);
                if (!result4.IsSuccess) throw new Exception(result4.Message);
                Result<bool> result5 = MusteriORM.Current.Delete(
                    new Musteri { MusteriID = rezervasyon.MusteriID });
                rezervasyon.Fiyat = 0;
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = "Rezervasyon başarıyla iptal eildi",
                    Data = rezervasyon
                };
            }
            catch (Exception ex)
            {
                return new Result<Rezervasyon>
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
