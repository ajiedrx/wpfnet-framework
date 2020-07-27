using System.Windows;

namespace MyFramework.ui_elements.progress_bar
{
    internal interface IMyDuration
    {
        void setMyDuration(double _second);
        Duration getMyDuration();

    }
}