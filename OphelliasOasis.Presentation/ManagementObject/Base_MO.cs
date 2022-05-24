using DevExpress.LookAndFeel;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class Base_MO<MO, UI> where MO : class, new() where UI : class, new() 
    {
        public UI ui;

        private static MO _currentMO;

        protected internal static MO CurrentMO
        {
            get 
            {
                if (_currentMO == null) _currentMO = new MO();
                return _currentMO; 
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
