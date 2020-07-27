using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyFramework.ui_elements.progress_bar
{
    internal class MyDuration : IMyDuration
    {
        private Duration duration;

        internal MyDuration() { }

        public void setMyDuration(double _second) {
            this.duration = new Duration(TimeSpan.FromSeconds(_second));
        }

        public Duration getMyDuration() {
            return this.duration;
        }

    }
}
