using System.Windows;

namespace Velacro.Enums {
    public class MyFontStretch
    {
        private FontStretch fontStretch;

        public static MyFontStretch NORMAL = new MyFontStretch(FontStretches.Normal);
        public static MyFontStretch MEDIUM = new MyFontStretch(FontStretches.Medium);
        public static MyFontStretch CONDENSED = new MyFontStretch(FontStretches.Condensed);
        public static MyFontStretch EXTRA_EXPANDED = new MyFontStretch(FontStretches.ExtraExpanded);
        public static MyFontStretch EXTRA_CONDENSED = new MyFontStretch(FontStretches.ExtraCondensed);
        public static MyFontStretch SEMI_CONDENSED = new MyFontStretch(FontStretches.SemiCondensed);
        public static MyFontStretch SEMI_EXPANDED = new MyFontStretch(FontStretches.SemiExpanded);
        public static MyFontStretch ULTRA_CONDENSED = new MyFontStretch(FontStretches.UltraCondensed);
        public static MyFontStretch ULTRA_EXPANDED = new MyFontStretch(FontStretches.UltraExpanded);
        
        private MyFontStretch(FontStretch _fontStretch) {
            fontStretch = _fontStretch;
        }
        
        internal FontStretch getFontStretch() {
            return fontStretch;
        }
    }
}
