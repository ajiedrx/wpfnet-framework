using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.tool_tip
{
    public class BuilderToolTip
    {
        IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderToolTip() { }
        public IMyToolTip activate(IMyContainer _container, String _instanceName)
        {
            IMyToolTip toolTip = new MyToolTip();

            IMyToolTipInjector toolTipInjector = (IMyToolTipInjector)toolTip;
            toolTipInjector.setMySolidColorBrush(mySolidColorBrush);

            return toolTip;
        }

    }
}
