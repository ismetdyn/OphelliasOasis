using DevExpress.XtraEditors;
using OphelliasOasis.Common;
using OphelliasOasis.ORM;
using OphelliasOasis.Presentation.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class MusterilerUI_MO : Base_MO<MusterilerUI_MO, MusterilerUI>
    {
        public MusterilerUI UI { get; set; }
        public MusterilerUI_MO()
        {
            UI = new MusterilerUI();
            UI.FormClosed += UI_FormClosed;
            UI.btnCikis.Click += BtnCikis_Click;
            UI.Load += new EventHandler(Load);
            UI.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<AnaMenuUI_MO, AnaMenuUI>();
            this.Dispose();
        }

        private void UI_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            UI.Dispose();
            InitializeForm.Current.Islem<AnaMenuUI_MO, AnaMenuUI>();
        }

        void Load(object sender = null, EventArgs e = null)
        {
            Result<DataTable> result = MusteriORM.Current.SelectDataTable();
            if (!result.IsSuccess) { XtraMessageBox.Show(result.Message); return; }
            else { UI.dgwMusteriler.DataSource = result.Data; return; }
        }
    }
}
