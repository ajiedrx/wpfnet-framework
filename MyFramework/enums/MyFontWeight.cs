using System.Windows;

namespace Velacro.Enums {
    public class MyFontWeight
    {
        private FontWeight fontWeight;
        public static MyFontWeight BOLD = new MyFontWeight(FontWeights.Bold);
        public static MyFontWeight NORMAL = new MyFontWeight(FontWeights.Normal);
        public static MyFontWeight SEMI_BOLD = new MyFontWeight(FontWeights.SemiBold);
        public static MyFontWeight BLACK = new MyFontWeight(FontWeights.Black);
        public static MyFontWeight ULTRA_BOLD = new MyFontWeight(FontWeights.UltraBold);

        private MyFontWeight(FontWeight _fontWeight) {
            fontWeight = _fontWeight;
        }

        internal FontWeight getFontWeight() {
            return fontWeight;
        }
    }
}
