using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.list_box
{
    public class BuilderListBox
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderListBox() { }

        public IMyListBox activate(IMyContainer _container, string _instanceName) {
            IMyListBox myListBox = new MyListBox(_container.getComponentByName(_instanceName));

            IMyListBoxInjector myListBoxInjector = (IMyListBoxInjector)myListBox;
            myListBoxInjector.setMySolidColorBrush(mySolidColorBrush);

            return myListBox;
        }
    }
}
