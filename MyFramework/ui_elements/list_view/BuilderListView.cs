using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.list_view
{
    public class BuilderListView
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderListView() { }
        public IMyListView activate(IMyContainer _container, string _instanceName) {
            IMyListView myListView = new MyListView(_container.getComponentByName(_instanceName));

            IMyListViewInjector myListViewInjector = (IMyListViewInjector)myListView;
            myListViewInjector.setMySolidColorBrush(mySolidColorBrush);

            return myListView;
        }
    }
}
