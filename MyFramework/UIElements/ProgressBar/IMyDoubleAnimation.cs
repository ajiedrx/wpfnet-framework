using System.Windows.Media.Animation;

namespace Velacro.UIElements.ProgressBar
{
    internal interface IMyDoubleAnimation
    {
        DoubleAnimation getDoubleAnimation();
        void setMyDoubleAnimation(double _toValue, IMyDuration _myDuration);

    }
}