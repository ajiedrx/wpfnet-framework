using System.Windows;

namespace Velacro.Enums {
    public class MyTextAlignment
    {
        private TextAlignment textAlignment;

        public static MyTextAlignment LEFT = new MyTextAlignment(TextAlignment.Left);
        public static MyTextAlignment CENTER = new MyTextAlignment(TextAlignment.Center);
        public static MyTextAlignment RIGHT = new MyTextAlignment(TextAlignment.Right);

        private MyTextAlignment(TextAlignment _textAlignment) {
            textAlignment = _textAlignment;
        }

        internal TextAlignment getTextAlignment() {
            return textAlignment;
        }
    }
}
