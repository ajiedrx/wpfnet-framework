using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.progress_bar
{
    internal interface IMyProgressBarInjector
    {
        void setMyDuration(IMyDuration _myDuration);
        void setMyDoubleAnimation(IMyDoubleAnimation _myDoubleAnimation);
    }
}
