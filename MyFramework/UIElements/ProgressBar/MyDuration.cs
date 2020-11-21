using System;
using System.Windows;

namespace Velacro.UIElements.ProgressBar
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
