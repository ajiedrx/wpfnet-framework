using System;
using System.Windows.Media;

namespace MyFramework.basic {
    public interface IMySolidColorBrush
    {
        void setMySolidColorBrush(Color _color);

        SolidColorBrush getMySolidColorBrush();

        SolidColorBrush setMyConverter(String _color);
        Color convertStringToColor(string _color);
    }
}
