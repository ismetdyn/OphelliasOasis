using DevExpress.XtraEditors;

namespace OphelliasOasis.Presentation.UI
{
    public partial class OdalarToolTipUI : XtraForm
    {
        private static OdalarToolTipUI _current;

        static object _lockObject = new object();
        public static OdalarToolTipUI Current()
        {
            lock(_lockObject)
            {
                if (_current == null) _current = new OdalarToolTipUI();
            }
                
                return _current; 
            
        }

        private OdalarToolTipUI()
        {
            InitializeComponent();
        }
    }
}