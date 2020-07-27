using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.progress_bar
{
    public class BuilderProgressBar
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        private IMyDuration myDuration = new MyDuration();
        private IMyDoubleAnimation myDoubleAnimation = new MyDoubleAnimation();

        public BuilderProgressBar() { }
        public IMyProgressBar activate(IMyContainer _container, string _instanceName)
        {
            IMyProgressBar myProgressBar = new MyProgressBar(_container.getComponentByName(_instanceName));

            IMyProgressBarInjector myProgressBarInjector = (IMyProgressBarInjector)myProgressBar;
            myProgressBarInjector.setMySolidColorBrush(mySolidColorBrush);
            myProgressBarInjector.setMyDuration(myDuration);
            myProgressBarInjector.setMyDoubleAnimation(myDoubleAnimation);

            return myProgressBar;
        }

    }
}
