using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OphelliasOasis.Presentation.UI;
using OphelliasOasis.Entity;
using OphelliasOasis.Common;
using OphelliasOasis.Business;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class AnaMenuUI_MO : Base_MO<AnaMenuUI_MO, AnaMenuUI>
    {
        public AnaMenuUI UI { get; set; }

        public AnaMenuUI_MO()
        {
            UI = new AnaMenuUI();
            UI.FormClosed += UI_FormClosed;
            UI.btnRaporlar.Click += BtnRaporlar_Click;
            UI.Show();
        }

        private void BtnRaporlar_Click(object sender, EventArgs e)
        {
            UI.Close();
            UI.Dispose();
            InitializeForm.Current.Islem<RaporlarUI_MO, RaporlarUI>();
            this.Dispose();
        }

        private void UI_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            //if (Program.kullanici == null) Application.Exit();
        }
    }

    
}
