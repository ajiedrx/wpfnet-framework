using System.Windows;

namespace MyFramework.enums {
    public class MyFontStyle
    {
        private FontStyle fontStyle;
        public static MyFontStyle NORMAL = new MyFontStyle(FontStyles.Normal);
        public static MyFontStyle ITALIC = new MyFontStyle(FontStyles.Italic);
        public static MyFontStyle OBLIQUE = new MyFontStyle(FontStyles.Oblique);

        private MyFontStyle(FontStyle _fontStyle) {
            fontStyle = _fontStyle;
        }
        internal FontStyle getFontStyle() {
            return fontStyle;
        }
    }
}
