using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OphelliasOasis.Presentation.UI
{
    public partial class MusteriUI : XtraForm
    {
        public MusteriUI()
        {
            InitializeComponent();
        }

        private void MusteriUI_Load(object sender, EventArgs e)
        {
            slider.LookAndFeel.UseDefaultLookAndFeel = false;
            slider.LookAndFeel.Style = LookAndFeelStyle.Flat;
            slider.Appearance.BackColor = Color.Transparent;
        }

        private void tgsTema_Toggled(object sender, EventArgs e)
        {
            if (((ToggleSwitch)sender).IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateRegion();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            Region prevRgn = Region;
            Region = new Region(CreateFormRegion(8));
            if (prevRgn != null)
                prevRgn.Dispose();
        }

        public GraphicsPath CreateFormRegion(int cornerRadius)
        {
            GraphicsPath GrpRect = new GraphicsPath();
            int width = Width + 1;
            int height = Height + 1;
            GrpRect.AddArc(new Rectangle(0, 0, cornerRadius * 5, cornerRadius * 5), 180f, 90f);//left-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 5) - 1, 0, cornerRadius * 5, cornerRadius * 5), -90f, 90f);//right-top
            GrpRect.AddArc(new Rectangle((width - cornerRadius * 5) - 1, (height - cornerRadius * 5) - 1, cornerRadius * 5, cornerRadius * 5), 0f, 90f);//right-bottom
            GrpRect.AddArc(new Rectangle(0, (height - cornerRadius * 5) - 1, cornerRadius * 5, cornerRadius * 5), 90f, 90f);//left-bottom
            GrpRect.CloseAllFigures();
            return GrpRect;
        }
    }
}