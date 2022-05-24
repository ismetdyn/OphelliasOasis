using DevExpress.XtraEditors;
using OphelliasOasis.Common;
using OphelliasOasis.Presentation.ManagementObject;
using System;
using System.Windows.Forms;

namespace OphelliasOasis.Presentation.UI
{
    public partial class InitializeForm : XtraForm
    {
        private static InitializeForm _current;

        public static InitializeForm Current
        {
            get 
            {
                if (_current == null) return new InitializeForm();
                return _current; 
            }
        }

        private InitializeForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Hide();
        }

        private void InitializeForm_Load(object sender, System.EventArgs e)
        {
            //Islem<LoginUI_MO, LoginUI>();
            //Islem<FrgtPsswrdUI_MO, FrgtPsswrdUI>();
            //Islem<UserUI_MO, UserUI>();
            //Islem<AnaMenuUI_MO, AnaMenuUI>();
            Islem<MusteriUI_MO, MusteriUI>();
            //Islem<RaporlarUI_MO, RaporlarUI>();
        }

        public void Islem<MO, UI>() where MO : class, new() where UI : Form, new()
        {
            MO mo = new MO();
        }
    }
}