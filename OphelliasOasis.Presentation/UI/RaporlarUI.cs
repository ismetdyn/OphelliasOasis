using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace OphelliasOasis.Presentation.UI
{
    public partial class RaporlarUI : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public RaporlarUI()
        {
            InitializeComponent();
        }

        private void tgsTema_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (((BarToggleSwitchItem)sender).Checked) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Basic");
        }
    }
}