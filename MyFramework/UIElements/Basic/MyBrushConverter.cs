using System.Windows.Media;

namespace Velacro.UIElements.Basic {
    public class MyBrushConverter
    {
        private BrushConverter brushConverter;

        public MyBrushConverter() {
            this.brushConverter = new BrushConverter();
        }

        public SolidColorBrush getConvertedSolidColorBrush(string _hexColor) {
            return (SolidColorBrush)brushConverter.ConvertFromString(_hexColor);
        }
    }
}
