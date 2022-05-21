using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OphelliasOasis.Common;
using OphelliasOasis.Business;
using OphelliasOasis.Presentation.ManagementObject;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Threading;
using OphelliasOasis.Presentation.UI;
using OphelliasOasis.Entity;

namespace OphelliasOasis.Presentation.ManagementObject
{
    class FrgtPsswrdUI_MO : Base_MO<FrgtPsswrdUI_MO, FrgtPsswrdUI>
    {
        int rand_num;
        FrgtPsswrdUI UI { get; set; }
        DynamicDataTransferObject ddto;
        Kullanici kullanici;

        public FrgtPsswrdUI_MO()
        {
            Program.kullanici = null;
            UI = new FrgtPsswrdUI();
            UI.btnGonder.Click += BtnGonder_Click;
            UI.btnDegisiklikKaydet.Click += BtnDegisiklikKaydet_Click;
            UI.btnKoduGir.Click += BtnKoduGir_Click;
            UI.FormClosed += UI_FormClosed;
            UI.Show();
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
           if (Program.kullanici == null) Application.Exit();
        }

        void FillDDTO() => ddto = UI.FillDDTO();

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            FillDDTO();
            Result<Kullanici> result = KullaniciBO.Current.ForgetPaswordSendMail(ddto);
            if (!result.IsSuccess) MessageBox.Show(result.Message);
            else
            {
                kullanici = result.Data;
                rand_num = Convert.ToInt32(result.Message);
                UI.lblKod.Visible = true;
                UI.teKod.Visible = true;
                UI.btnKoduGir.Visible = true;
            }
        }

        private void BtnKoduGir_Click(object sender, EventArgs e)
        {
            FillDDTO();
            if (rand_num != Convert.ToInt32((string)ddto["Kod"]))
                MessageBox.Show("Kod Hatalı", "Kod Hatalı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else UI.PanelVisibility();
        }

        private void BtnDegisiklikKaydet_Click(object sender, EventArgs e)
        {
            FillDDTO();
            if ((string)ddto["Sifre"] != (string)ddto["SifreTekrar"])
                MessageBox.Show("Şifreler Uyuşmuyor");
            else
            {
                UI.Close();
                UI.Dispose();
                kullanici.Sifre = (string)ddto["Sifre"];
                KullaniciBO.Current.UpdateUser(kullanici);
                Program.kullanici = kullanici.DeepCopy();
                switch(kullanici.KullaniciTipID)
                {
                    case 1:
                        //InitializeForm.Current.Islem<AdminUI_MO, AdminUI>();
                        break;
                    case 2:
                        //InitializeForm.Current.Islem<SoruEkleUI_MO, SoruEkleUI>();
                        break;
                    case 3:
                        //InitializeForm.Current.Islem<UserUI_MO, UserUI>();
                        break;
                    default:
                        break;
                }
                
                this.Dispose();
            }



            kullanici.Sifre = (string)ddto["Sifre"];
            Result<bool> result = KullaniciBO.Current.UpdateUser(kullanici);
            if(!result.IsSuccess) MessageBox.Show(result.Message);
            
            else
            {
                MessageBox.Show(result.Message);
                UI.Close();
                UI.Dispose();
                this.Dispose();
                Program.kullanici = kullanici.DeepCopy();
            }
        }
    }
}
