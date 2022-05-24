using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OphelliasOasis.Common;
using OphelliasOasis.Entity;
using OphelliasOasis.ORM;
using OphelliasOasis.Presentation.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class RezervasyonlarUI_MO : Base_MO<RezervasyonlarUI_MO, RezervasyonlarUI>
    {
        public RezervasyonlarUI UI { get; set; }
        public RezervasyonlarUI_MO()
        {
            UI = new RezervasyonlarUI();
            UI.Load += new EventHandler(Load);
            UI.btnCikis.Click += BtnCikis_Click;
            UI.btnCheckin.Click += BtnCheckin_Click;
            UI.btnCheckout.Click += BtnCheckout_Click;
            UI.Show();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)UI.dgwRezervasyonlar.MainView).GetSelectedRows();
            if(selRows.Length > 1 || selRows.Length <= 0) 
            { 
                XtraMessageBox.Show("Tek seferde sadece bir adet rezervasyon düzenlenebilir.");
                return;
            }
            DataRowView RezervasyonID = (DataRowView)(UI.dgwRezervasyonlar.MainView.GetRow(selRows[0]));
            Rezervasyon rezervasyon = RezervasyonID.Row.ToEntity<Rezervasyon>().Data;
            rezervasyon.Checkout = DateTime.Now;
            rezervasyon.AktifMi = false;
            if (rezervasyon.RezervasyonID == 3 || rezervasyon.RezervasyonID == 4) rezervasyon.OdemeTarih = DateTime.Now; 
            Result<bool> result =  RezervasyonORM.Current.Update(rezervasyon);
            if(!result.IsSuccess) { MessageBox.Show(result.Message); return; }
            MusteriORM.Current.FaturaBas(new Musteri { MusteriID = rezervasyon.MusteriID }) ;
            Load();
        }

        private void BtnCheckin_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)UI.dgwRezervasyonlar.MainView).GetSelectedRows();
            if (selRows.Length > 1 || selRows.Length <= 0)
            {
                XtraMessageBox.Show("Tek seferde sadece bir adet rezervasyon düzenlenebilir.");
                return;
            }
            DataRowView RezervasyonID = (DataRowView)(UI.dgwRezervasyonlar.MainView.GetRow(selRows[0]));
            Rezervasyon rezervasyon = RezervasyonID.Row.ToEntity<Rezervasyon>().Data;
            rezervasyon.CheckIn = DateTime.Now;
            rezervasyon.AktifMi = true;
            Result<bool> result = RezervasyonORM.Current.Update(rezervasyon);
            if (!result.IsSuccess) { MessageBox.Show(result.Message); return; }
            Load();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<AnaMenuUI_MO, AnaMenuUI>();
            this.Dispose();
        }

        void Load(object sender = null, EventArgs e = null)
        {
            Result<DataTable> result = RezervasyonORM.Current.SelectDataTable();
            if (!result.IsSuccess) { XtraMessageBox.Show(result.Message); return; }
            else { UI.dgwRezervasyonlar.DataSource = result.Data; return; }
        }

    }
}
