using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.data_grid
{
    public class BuilderDataGrid
    {
        public BuilderDataGrid() { }

        public IMyDataGrid activate(IMyContainer _container, string _instanceName)
        {
            IMyDataGrid myDataGrid = new MyDataGrid(_container.getComponentByName(_instanceName));
            return myDataGrid;
        }

    }
}
