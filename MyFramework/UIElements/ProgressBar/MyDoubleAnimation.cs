using System.Windows.Media.Animation;

namespace Velacro.UIElements.ProgressBar
{
    internal class MyDoubleAnimation : IMyDoubleAnimation
    {
        private DoubleAnimation doubleAnimation;
        internal MyDoubleAnimation() { }

        public DoubleAnimation getDoubleAnimation() {
            return this.doubleAnimation;
        }
        
        public void setMyDoubleAnimation(double _toValue, IMyDuration _myDuration) {
            this.doubleAnimation = new DoubleAnimation(_toValue, _myDuration.getMyDuration());
        }

    }
}
