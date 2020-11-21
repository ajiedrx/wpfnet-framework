using System.Windows;

namespace Velacro.Enums {
    public class MyTextWrapping
    {
        private TextWrapping textWrapping;
        public static MyTextWrapping WRAP = new MyTextWrapping(TextWrapping.Wrap);
        public static MyTextWrapping NO_WRAP = new MyTextWrapping(TextWrapping.NoWrap);
        public static MyTextWrapping WRAP_WITH_OVER_FLOW = new MyTextWrapping(TextWrapping.WrapWithOverflow);
        private MyTextWrapping(TextWrapping _textWrapping) {
            textWrapping = _textWrapping;
        }

        internal TextWrapping getTextWrapping() {
            return textWrapping;
        }

    }
}
