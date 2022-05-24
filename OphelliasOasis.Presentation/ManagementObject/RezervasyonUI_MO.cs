using DevExpress.XtraEditors;
using OphelliasOasis.Business;
using OphelliasOasis.Business.Abstract;
using OphelliasOasis.Business.RezervasyonBO;
using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using OphelliasOasis.Presentation.UI;
using System;
using System.Windows.Forms;
using OphelliasOasis.ORM;


namespace OphelliasOasis.Presentation.ManagementObject
{
    public class RezervasyonUI_MO
    {
        public RezervasyonUI UI { get; set; }
        Rezervasyon rezervasyon { get; set; }

        Musteri musteri { get; set; }
        public RezervasyonUI_MO()
        {
            UI = new RezervasyonUI();
            UI.btnCikis.Click += BtnCikis_Click;
            UI.btnRezervasyonYap.Click += BtnRezervasyonYap_Click;
            UI.btnRezervasyonAraRezervasyonGuncelle.Click += BtnRezervasyonAraRezervasyonGuncelle_Click;
            UI.btnRezervasyonAraRezervasyonIptal.Click += BtnRezervasyonAraRezervasyonIptal_Click;
            UI.Show();
        }


        private void BtnRezervasyonYap_Click(object sender, EventArgs e)
        {
            #region Input_Check
            if (UI.deRezervasyonYapBitis.DateTime == null || UI.deRezervasyonYapBaslangic.DateTime == null)
            { XtraMessageBox.Show("Lutfen geçerli zaman dilimleri seçiniz."); return; }

            if(UI.deRezervasyonYapBaslangic.DateTime > UI.deRezervasyonYapBitis.DateTime)
            { XtraMessageBox.Show( "Rezervasyon bitiş tarihi basşlangıç tarihinden küçük olamaz"); return; }

            if(UI.deRezervasyonYapBaslangic.DateTime.Day < DateTime.Now.Day || UI.deRezervasyonYapBitis.DateTime < DateTime.Now)
            { XtraMessageBox.Show(
                    "Şuanlık bu hizmeti veremiyoruz.\n" +
                    "Lütfen daha sonra tekrar dneyiniz...\n(Geçmişe Yolculuk)"); return; }

            if(UI.beAd.Text == null ) { XtraMessageBox.Show("Ad boş olamaz."); return; }
            
            if(UI.beSoyad.Text == null) { XtraMessageBox.Show("Soyad boş olamaz."); return; }

            #endregion
            musteri = new Musteri
            {
                MusteriAd = UI.beAd.Text,
                MusteriSoyad = UI.beSoyad.Text,
                MusteriEposta = UI.beEposta.Text,
            };
            rezervasyon = new Rezervasyon
            {
                RezervasyonBaslangicTarihi = UI.deRezervasyonYapBaslangic.DateTime,
                RezervasyonBitisTarihi = UI.deRezervasyonYapBitis.DateTime,
                CheckIn = DateTime.Now,
                Checkout = DateTime.Now,
                OdemeTarih = DateTime.Now,
                RezervasyonTalepTarihi = DateTime.Now,
            };
            switch (UI.cbRezervasyonTuru.SelectedIndex)
            {
                case 0:
                    if (rezervasyon.RezervasyonBaslangicTarihi > DateTime.Now.AddDays(60))
                    {
                        XtraMessageBox.Show("Rezervasyon tarihinize 45 gün kala 15 gün içerisinde ödeme yapmak sorumluluğundasınız.");
                        Result<Rezervasyon> result1 = _60GunOncedenRezervasyonBO.Current.RezervasyonYap(rezervasyon, musteri, 100);
                        if(!result1.IsSuccess) { XtraMessageBox.Show(result1.Message); return; }
                        else XtraMessageBox.Show(string.Format("Rezervasyon kodunuz {0}\n Ödeyeceğiniz {1} TL", 
                           result1.Data.RezervasyonID, result1.Data.Fiyat.ToString()), "Başarılı");
                    }
                    else { XtraMessageBox.Show("Bu rezervasyon türünde minimum 2 ay sonrasına rezervasyon verilir."); return; }
                    break;
                case 1:
                    if (rezervasyon.RezervasyonBaslangicTarihi > DateTime.Now.AddDays(90))
                    {
                        XtraMessageBox.Show("Bu tarih aralığındaki rezervasyonlarda ücret önceden ödenir");
                        XtraMessageBox.Show("Kart bilgisi alındı");
                        musteri.KartBilgi = true;
                        rezervasyon.OdemeOnay = true;
                        Result<Rezervasyon> result2 = OnOdemeliRezervasyonBO.Current.RezervasyonYap(rezervasyon, musteri, 100);
                        if(!result2.IsSuccess) { XtraMessageBox.Show(result2.Message); return; }
                        else XtraMessageBox.Show(string.Format("Rezervasyon kodunuz {0}\n Kartınızdan kesilen tutar {1} TL",
                            result2.Data.RezervasyonID, result2.Data.Fiyat.ToString()), "Başarılı");
                    }
                    else { XtraMessageBox.Show("Bu rezervasyon türünde minimum 3 ay sonrasına rezervasyon verilir."); return; }
                    break;
                case 2:
                       XtraMessageBox.Show("Bu rezervsyon türünde ödeme konaklama sonunda yapılır");
                        musteri.KartBilgi = true;
                        Result<Rezervasyon> result3 = Standart_Klasik_RezervasyonBO.Current.RezervasyonYap(rezervasyon, musteri, 100);
                       if(!result3.IsSuccess) { XtraMessageBox.Show(result3.Message); return; }
                       else XtraMessageBox.Show(string.Format("Rezervasyon kodunuz {0}\n Ödeyeceğiniz tutar {1} TL",
                           result3.Data.RezervasyonID, result3.Data.Fiyat.ToString()), "Başarılı");
                    break;
                case 3:
                    if (rezervasyon.RezervasyonBaslangicTarihi > DateTime.Now.AddDays(30))
                    {
                        XtraMessageBox.Show("Bu rezervsyon türünde ödeme konaklama sonunda yapılır");
                        Result<Rezervasyon> result4 = TesvikRezervasyonBO.Current.RezervasyonYap(rezervasyon, musteri, 100);
                        if (!result4.IsSuccess) { XtraMessageBox.Show(result4.Message); return; }
                        else XtraMessageBox.Show(string.Format("Rezervasyon kodunuz {0}\n Ödeyeceğiniz tutar {1} TL",
                            result4.Data.RezervasyonID, result4.Data.Fiyat.ToString()), "Başarılı");
                    }
                    else { XtraMessageBox.Show("Tesvik rezervasyonu sadece gelecek 30 gün için geçerlidir."); return; }
                    break;   
                default:
                    XtraMessageBox.Show("Lütfen rezervasyon türü seçiniz");
                    return;
            }
        }

        private void BtnRezervasyonAraRezervasyonGuncelle_Click(object sender, EventArgs e)
        {
            if (UI.beRezervasyonKodRezervasyonGuncelle.Text == null || 
                UI.beRezervasyonKodRezervasyonGuncelle.Text.Length == 0)
            { XtraMessageBox.Show("Lutfen geçerli bir kod giriniz."); return; }

            int kod = Int32.Parse(UI.beRezervasyonKodRezervasyonGuncelle.Text);
            Result<Rezervasyon> result = RezervasyonORM.Current.GetByID(kod);

            if (!result.IsSuccess) { XtraMessageBox.Show("rezervasyon bulunamadı"); return; }
            else this.rezervasyon = result.Data;

            UI.panelRezervasyonKodRezervasyonGuncelle.Visible = false;
            UI.panelRezervasyonGuncelle.Visible = true;

            #region Input_Check
            if (UI.deRezervasyonGuncelleBaslangic.DateTime == null || UI.deRezervasyonGuncellBitis.DateTime == null)
            { XtraMessageBox.Show("Lutfen geçerli zaman dilimleri seçiniz."); return; }

            if (UI.deRezervasyonGuncelleBaslangic.DateTime > UI.deRezervasyonGuncellBitis.DateTime)
            { XtraMessageBox.Show( "Rezervasyon bitiş tarihi basşlangıç tarihinden küçük olamaz"); return; }

            if (UI.deRezervasyonGuncelleBaslangic.DateTime.Day < DateTime.Now.Day || UI.deRezervasyonGuncellBitis.DateTime < DateTime.Now)
            { XtraMessageBox.Show(
                    "Şuanlık bu hizmeti veremiyoruz.\n" +
                    "Lütfen daha sonra tekrar dneyiniz...\n(Geçmişe Yolculuk)"); return; }
            #endregion

            rezervasyon.RezervasyonBaslangicTarihi = UI.deRezervasyonGuncelleBaslangic.DateTime;
            rezervasyon.RezervasyonBitisTarihi = UI.deRezervasyonGuncellBitis.DateTime;
            switch (rezervasyon.RezervasyonTipID)
            {
                case 1:
                    Result<Rezervasyon> result1 = OnOdemeliRezervasyonBO.Current.RezervasyonGuncelle(rezervasyon);
                    XtraMessageBox.Show(result1.Message);
                    break;
                case 2:
                    Result<Rezervasyon> result2 = _60GunOncedenRezervasyonBO.Current.RezervasyonGuncelle(rezervasyon);
                    XtraMessageBox.Show(result2.Message);
                    break;
                case 3:
                    Result<Rezervasyon> result3 = Standart_Klasik_RezervasyonBO.Current.RezervasyonGuncelle(rezervasyon);
                    XtraMessageBox.Show(result3.Message);
                    break;
                case 4:
                    Result<Rezervasyon> result4 = TesvikRezervasyonBO.Current.RezervasyonGuncelle(rezervasyon);
                    XtraMessageBox.Show(result4.Message);
                    break;
                default:
                    break;
            }
        }

        private void BtnRezervasyonAraRezervasyonIptal_Click(object sender, EventArgs e)
        {
            if (UI.beRezervasyonKodRezervasyonIptal.Text == null || UI.beRezervasyonKodRezervasyonIptal.Text.Length == 0)
            { XtraMessageBox.Show("Lutfen geçerli bir kod giriniz."); return; }

            int kod = Int32.Parse(UI.beRezervasyonKodRezervasyonIptal.Text);
            Result<Rezervasyon> result = RezervasyonORM.Current.GetByID(kod);

            if (!result.IsSuccess) { XtraMessageBox.Show("rezervasyon bulunamadı"); return; }
            else this.rezervasyon = result.Data;

            switch (rezervasyon.RezervasyonTipID)
            {
                case 1:
                    Result<Rezervasyon> result1 = OnOdemeliRezervasyonBO.Current.RezervasyonIptal(rezervasyon);
                    XtraMessageBox.Show(result1.Message);
                    break;
                case 2:
                    Result<Rezervasyon> result2 = _60GunOncedenRezervasyonBO.Current.RezervasyonIptal(rezervasyon);
                    XtraMessageBox.Show(result2.Message);
                    break;
                case 3:
                    Result<Rezervasyon> result3 = Standart_Klasik_RezervasyonBO.Current.RezervasyonIptal(rezervasyon);
                    XtraMessageBox.Show(result3.Message);
                    break;
                case 4:
                    Result<Rezervasyon> result4 = TesvikRezervasyonBO.Current.RezervasyonIptal(rezervasyon);
                    XtraMessageBox.Show(result4.Message);
                    break;
                default:
                    break;
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e) => Application.Exit();
    }
}
