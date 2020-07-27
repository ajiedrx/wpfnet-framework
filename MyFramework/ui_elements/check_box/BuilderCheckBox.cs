using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.check_box
{
    public class BuilderCheckBox
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderCheckBox() { }
        public IMyCheckBox activate(IMyContainer _container, string _instanceName) {
            IMyCheckBox myCheckBox = new MyCheckBox(_container.getComponentByName(_instanceName));
            IMyCheckBoxInjector myCheckBoxInjector = (IMyCheckBoxInjector)myCheckBox;
            myCheckBoxInjector.setMySolidColorBrush(mySolidColorBrush);
            return myCheckBox;
        }
    }
}
