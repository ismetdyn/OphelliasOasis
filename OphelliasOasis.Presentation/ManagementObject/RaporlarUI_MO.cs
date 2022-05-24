using OphelliasOasis.Presentation.UI;
using System;
using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using OphelliasOasis.Business;
using System.Windows.Forms;
using System.Diagnostics;
using OphelliasOasis.ORM;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using System.Data;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class RaporlarUI_MO
    {
        public RaporlarUI UI { get; set; }
        
        public RaporlarUI_MO()
        {
            UI = new RaporlarUI();
            UI.btnBeklenenDolulukRaporu.Click += new EventHandler(Click);
            UI.btnBeklenenOdaGelirRaporu.Click += new EventHandler(Click);
            UI.btnGunlukDolulukRaporu.Click += new EventHandler(Click);
            UI.btnGunlukGelenlerRaporu.Click += new EventHandler(Click);
            UI.btnTesvikRaporu.Click += new EventHandler(Click);
            UI.btnKaydetPDF.ItemClick += new ItemClickEventHandler(Kaydet);
            UI.btnKaydetEXCEL.ItemClick += new ItemClickEventHandler(Kaydet);
            UI.btnYazdir.Click += new EventHandler(Yazdir);
            //UI.btnYazdir.Click += BtnYazdir_Click;
            //UI.btnRaporKaydet.Click += BtnRaporKaydet_Click;
            UI.FormClosed += UI_FormClosed;
            UI.Show();
        }

        // TODO: Boş Grid hatasını hallet. 

        void Kaydet(object sender, ItemClickEventArgs e)
        {
            string tag = ((e.Item)).Tag.ToString();
            string path = "";
            if (UI.xtraFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = string.Format(UI.xtraFolderBrowserDialog.SelectedPath);
                path += string.Format("\\Rapor." + e.Item.Tag);
                switch((e.Item).Tag)
                {
                    case "pdf":
                        UI.dgwRapor.ExportToPdf(path);
                        break;
                    case "xlsx":
                        UI.dgwRapor.ExportToXlsx(path);
                        break;
                }
                Process.Start(path);
            }
        }

        void Yazdir(object sender, EventArgs e)
        {
            if(!UI.dgwRapor.IsPrintingAvailable)
            {
                XtraMessageBox.Show("Yazdırma hatası", "Hata");
                return;
            }
            UI.dgwRapor.ShowPrintPreview();
        }

        private void BtnYazdir_Click(object sender, EventArgs e) => UI.dgwRapor.ShowPrintPreview();

        private void UI_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            UI.Dispose();
            InitializeForm.Current.Islem<AnaMenuUI_MO, AnaMenuUI>();
            //this.Dispose();
        }

        void Click(object sender, EventArgs e)
        {
            UI.dgwRapor.DataSource = new DataTable();
            string str = ((AccordionControlElement)sender).Tag.ToString();
            Result<DataTable> result = RaporORM.RaporGetir(str);
            if (!result.IsSuccess) { MessageBox.Show(result.Message); return; }
            else UI.dgwRapor.DataSource = result.Data;
        }
    }
}
