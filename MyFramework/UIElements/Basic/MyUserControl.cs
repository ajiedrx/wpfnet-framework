using System.Windows.Controls;

namespace Velacro.UIElements.Basic {
    public class MyUserControl : UserControl, IMyContainer
    {
        public MyUserControl() { 
           
        }

        public object getComponentByName(string _instanceName) {
            return this.FindName(_instanceName);
        }
    }
}
