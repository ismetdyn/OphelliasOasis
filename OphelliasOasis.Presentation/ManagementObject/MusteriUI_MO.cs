using DevExpress.XtraEditors;
using OphelliasOasis.Presentation.UI;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class MusteriUI_MO : Base_MO<MusteriUI_MO, MusteriUI>
    {
        public MusteriUI UI { get; set; }
        public MusteriUI_MO()
        {
            UI = new MusteriUI();
            UI.btnYoneticiGiris.ItemClick += BtnYoneticiGiris_ItemClick;
            UI.btnCalisanGiris.ItemClick += BtnCalisanGiris_ItemClick;
            UI.btnRezervasyonIslemleri.ItemClick += BtnRezervasyonGuncelle_ItemClick;
            UI.slider.ContextButtonClick += Slider_ContextButtonClick;
            UI.Show();
        }

        private void Slider_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<RezervasyonUI_MO, RezervasyonUI>();
            this.Dispose();
        }

        private void BtnYoneticiGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<LoginUI_MO, LoginUI>();
            this.Dispose();
        }

        private void BtnCalisanGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<LoginUI_MO, LoginUI>();
            this.Dispose();
        }


        private void BtnRezervasyonGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<RezervasyonUI_MO, RezervasyonUI>();
            this.Dispose();
        }
    }
}
