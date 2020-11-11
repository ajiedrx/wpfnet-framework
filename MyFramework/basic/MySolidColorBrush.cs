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
            if (_hexColor != null) {
                this.solidColorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(_hexColor);
            }
            return this.solidColorBrush;
        }

        public Color convertStringToColor(string _color) {
            if (_color != null) {
                return (Color)ColorConverter.ConvertFromString(_color);
            }
            return Colors.Black;
        }
    }
}
