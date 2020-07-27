using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.password_box
{
    public class BuilderPasswordBox
    {
        IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderPasswordBox() { }
        public IMyPasswordBox activate(IMyContainer _container, string _instanceName) {
            IMyPasswordBox myPasswordBox = new MyPasswordBox(_container.getComponentByName(_instanceName));

            IMyPasswordBoxInjector myPasswordBoxInjector = (IMyPasswordBoxInjector)myPasswordBox;
            myPasswordBoxInjector.setMySolidColorBrush(mySolidColorBrush);

            return myPasswordBox;
        }
    }
}
