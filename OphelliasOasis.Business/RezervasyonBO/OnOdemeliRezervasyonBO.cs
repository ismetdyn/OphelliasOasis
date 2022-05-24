using OphelliasOasis.Business.Abstract;
using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using OphelliasOasis.ORM;
using System;

namespace OphelliasOasis.Business.RezervasyonBO
{
    public class OnOdemeliRezervasyonBO : AbstractRezervasyonBO<OnOdemeliRezervasyonBO>
    {
        public override Result<Rezervasyon> RezervasyonYap(
            Rezervasyon rezervasyon,
            Musteri musteri,
            int beklenenDolulukOranı)
        {
            try
            {
                if (DateTime.Now.AddDays(90) >
                    rezervasyon.RezervasyonBaslangicTarihi)
                    throw new Exception("Rezervasyon a 90 günden az var");
                if (!rezervasyon.OdemeOnay) throw new Exception(
                    "Odeme yapılmadı");
                Result<Oda> result1 = OdaORM.Current.GetByID(1);
                if (!result1.IsSuccess) throw new Exception(result1.Message);
                int gunSayisi = (int)(rezervasyon.RezervasyonBitisTarihi -
                    rezervasyon.RezervasyonBaslangicTarihi).TotalDays;
                rezervasyon.Fiyat = gunSayisi * (result1.Data.TabanFiyat * 75 /100);
                rezervasyon.RezervasyonTipID = 1;
                rezervasyon.RezervasyonTalepTarihi = DateTime.Now;
                rezervasyon.OdemeOnay = true;
                Result<Rezervasyon> result2 = EkleveGetir(rezervasyon, musteri);
                if (!result2.IsSuccess) throw new Exception(result2.Message);
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = "Rezervasyon işlemi başarılı",
                    Data = result2.Data
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

        public override Result<Rezervasyon> RezervasyonGuncelle(
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
                rezervasyon.Fiyat = rezervasyon.Fiyat * 210 / 100;
                Result<bool> result4 = RezervasyonORM.Current.Update(rezervasyon);
                if (!result4.IsSuccess) throw new Exception(result4.Message);
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = "Rezervasyon güncelleme işlemi başarılı",
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
                if(rezervasyon == null)
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
                    new Musteri { MusteriID = rezervasyon.MusteriID});
                rezervasyon.Fiyat = 0;
                return new Result<Rezervasyon>
                {
                    IsSuccess = true,
                    Message = "Rezervasyon iptal edildi",
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
