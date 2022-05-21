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

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class RaporlarUI_MO
    {
        public RaporlarUI UI { get; set; }
        
        public RaporlarUI_MO()
        {
            UI = new RaporlarUI();
            UI.btnBeklenenDolulukRaporu.Click += new EventHandler(Click);
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

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            UI.dgwRapor.ShowPrintPreview();
            
        }


        private void UI_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            UI.Dispose();
            InitializeForm.Current.Islem<AnaMenuUI_MO, AnaMenuUI>();
            //this.Dispose();
        }

        void Click(object sender, EventArgs e)
        {
            UI.dgwRapor.DataSource = KullaniciORM.Current.SelectDataTable();
            MessageBox.Show("CLİCK");
        }
    }
}
