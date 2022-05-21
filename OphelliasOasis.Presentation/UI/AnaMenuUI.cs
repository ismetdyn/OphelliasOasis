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
    public partial class AnaMenuUI : XtraForm
    {
        public AnaMenuUI()
        {
            InitializeComponent();
        }

        private void btnOdalar_MouseEnter(object sender, EventArgs e)
        {
            OdalarToolTipUI.Current().Location = new Point(MousePosition.X + 20, MousePosition.Y);
            OdalarToolTipUI.Current().Show();
        }

        private void btnOdalar_MouseMove(object sender, MouseEventArgs e)
        {
            OdalarToolTipUI.Current().Location = new Point(MousePosition.X + 20, MousePosition.Y);
        }

        private void btnOdalar_MouseLeave(object sender, EventArgs e)
        {
            OdalarToolTipUI.Current().Hide();
        }

        private void btnOdalar_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void tgsTema_Toggled(object sender, EventArgs e)
        {
            if (((ToggleSwitch)sender).IsOn) UserLookAndFeel.Default.SetSkinStyle("Office 2019 Black");
            else UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
        }
    }
}