using MyFramework.basic;
using MyFramework.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.text_box
{
    public class BuilderTextBox
    {
        IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderTextBox() { }
        public IMyTextBox activate(IMyContainer _container, String _instanceName) {
            IMyTextBox textBox = new MyTextBox(_container.getComponentByName(_instanceName));

            IMyTextBoxInjector textBoxInjector = (IMyTextBoxInjector)textBox;
            textBoxInjector.setMySolidColorBrush(mySolidColorBrush);

            return textBox;
        }
    }
}
