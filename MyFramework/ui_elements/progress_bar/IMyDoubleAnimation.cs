using System.Windows.Media.Animation;

namespace MyFramework.ui_elements.progress_bar
{
    internal interface IMyDoubleAnimation
    {
        DoubleAnimation getDoubleAnimation();
        void setMyDoubleAnimation(double _toValue, IMyDuration _myDuration);

    }
}