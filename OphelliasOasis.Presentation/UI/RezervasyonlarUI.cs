using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;

namespace OphelliasOasis.Presentation.UI
{
    public partial class RezervasyonlarUI : DevExpress.XtraEditors.XtraForm
    {
        public RezervasyonlarUI()
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