using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.combo_box {
    public class BuilderComboBox
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderComboBox() { }

        public IMyComboBox activate(IMyContainer _container, String _instanceName) {
            IMyComboBox comboBox = new MyComboBox(_container.getComponentByName(_instanceName));

            IMyComboBoxInjector comboBoxInjector = (IMyComboBoxInjector)comboBox;
            comboBoxInjector.setMySolidColorBrush(mySolidColorBrush);

            return comboBox;
        }
    }
}
