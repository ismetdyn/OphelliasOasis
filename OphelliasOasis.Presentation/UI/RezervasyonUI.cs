using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OphelliasOasis.Presentation.UI
{
    public partial class RezervasyonUI : XtraForm
    {
        public RezervasyonUI()
        {
            InitializeComponent();
        }

        private void RezervasyonUI_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            WindowsFormsSettings.UseAdvancedFilterEditorControl = DevExpress.Utils.DefaultBoolean.True;
            //deRezervasyonYapBaslangic.EditValueChanging += new ChangingEventHandler(SetError);
            //deRezervasyonYapBaslangic.Validating += new CancelEventHandler(SetError2);
            //deRezervasyonYapBitis.EditValueChanging += new ChangingEventHandler(SetError);
            //deRezervasyonYapBitis.Validating += new CancelEventHandler(SetError2);

        }
        private void tgsTema_Toggled(object sender, EventArgs e)
        {
            if (((ToggleSwitch)sender).IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        }


        void SetError(object sender, ChangingEventArgs e)
        {
            if (((DateEdit)sender).DateTime == null)
            {
                btnRezervasyonYap.Enabled = false;
                errorProvider.SetError((DateEdit)sender, "Alan boş olamaz", ErrorType.Warning);
                errorProvider.SetIconAlignment(((DateEdit)sender), ErrorIconAlignment.MiddleRight);
            }

            if (deRezervasyonYapBaslangic.DateTime.Year < DateTime.Now.Year ||
                deRezervasyonYapBaslangic.DateTime.Month < DateTime.Now.Month ||
                deRezervasyonYapBaslangic.DateTime.Day < DateTime.Now.Day)
            {
                btnRezervasyonYap.Enabled = false;
                errorProvider.SetError((DateEdit)sender, "Geçmiş zaman", ErrorType.Warning);
                errorProvider.SetIconAlignment(((DateEdit)sender), ErrorIconAlignment.MiddleRight);
            }
        }

        void SetError2(object sender, EventArgs e)
        {
            if (((DateEdit)sender).DateTime == null)
            {
                btnRezervasyonYap.Enabled = false;
                errorProvider.SetError((DateEdit)sender, "Alan boş olamaz", ErrorType.Warning);
                errorProvider.SetIconAlignment(((DateEdit)sender), ErrorIconAlignment.MiddleRight);
            }

            if (deRezervasyonYapBaslangic.DateTime.Year < DateTime.Now.Year ||
                deRezervasyonYapBaslangic.DateTime.Month < DateTime.Now.Month ||
                deRezervasyonYapBaslangic.DateTime.Day < DateTime.Now.Day)
            {
                btnRezervasyonYap.Enabled = false;
                errorProvider.SetError((DateEdit)sender, "Geçmiş zaman", ErrorType.Warning);
                errorProvider.SetIconAlignment(((DateEdit)sender), ErrorIconAlignment.MiddleRight);
            }
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