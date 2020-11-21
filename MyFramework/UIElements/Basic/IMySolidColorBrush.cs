using System.Windows.Media;

namespace Velacro.UIElements.Basic {
    public interface IMySolidColorBrush
    {
        void setMySolidColorBrush(Color _color);

        SolidColorBrush getMySolidColorBrush();

        SolidColorBrush convertFromHex(string _hexColor);
        Color convertStringToColor(string _color);
    }
}
