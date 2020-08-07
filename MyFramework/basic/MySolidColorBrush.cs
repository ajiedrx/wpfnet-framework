using System;
using System.Windows.Media;

namespace MyFramework.basic {
    public class MySolidColorBrush : IMySolidColorBrush
    {
        private SolidColorBrush solidColorBrush;

        public MySolidColorBrush() { }

        public void setMySolidColorBrush(Color _color) {
            this.solidColorBrush = new SolidColorBrush(_color);
        }

        public SolidColorBrush getMySolidColorBrush() {
            return this.solidColorBrush;
        }

        public SolidColorBrush convertFromHex(string _hexColor) {
            this.solidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(_hexColor);
            return this.solidColorBrush;
        }

        public Color convertStringToColor(string _color) {
            return (Color)ColorConverter.ConvertFromString(_color);
        }
    }
}
