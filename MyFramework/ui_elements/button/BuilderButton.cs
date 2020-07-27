using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.button
{
    public class BuilderButton
    {
        IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderButton() { }

        public IMyButton activate(IMyContainer _container, String _instanceName)
        {
            IMyButton button = new MyButton(_container.getComponentByName(_instanceName));

            IMyButtonInjector comboBoxInjector = (IMyButtonInjector)button;
            comboBoxInjector.setMySolidColorBrush(mySolidColorBrush);

            return button;
        }
    }
}
