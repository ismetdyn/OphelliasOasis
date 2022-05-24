using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OphelliasOasis.Presentation.UI
{
    public partial class MusterilerUI : DevExpress.XtraEditors.XtraForm
    {
        public MusterilerUI()
        {
            InitializeComponent();
        }

        private void tgsTema_Toggled(object sender, EventArgs e)
        {
            if (((ToggleSwitch)sender).IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        }
    }
}