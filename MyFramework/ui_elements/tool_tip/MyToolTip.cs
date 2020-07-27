using MyFramework.basic;
using MyFramework.enums;
using System.Windows;
using System.Windows.Controls;

namespace MyFramework.ui_elements.tool_tip {
    internal class MyToolTip : IMyToolTip, IMyToolTipInjector
    {
        private ToolTip myToolTip_tt;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyToolTip() {
            
        }

        #region properties
        public IMyToolTip setFontWeight(MyFontWeight myFontWeight) {
            myToolTip_tt.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyToolTip setFontStretch(MyFontStretch myFontStretch) {
            myToolTip_tt.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyToolTip setFontSize(int _fontSize) {
            myToolTip_tt.FontSize = _fontSize;
            return this;
        }

        public IMyToolTip setFontStyle(MyFontStyle myFontStyle) {
            myToolTip_tt.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyToolTip setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myToolTip_tt.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyToolTip setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myToolTip_tt.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyToolTip setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myToolTip_tt.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyToolTip setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myToolTip_tt.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyToolTip setText(string _text) {
            myToolTip_tt.Content = _text;
            return this;
        }

        public IMyToolTip setTextColor(string _color) {
            myToolTip_tt.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyToolTip setBackgroundColor(string _color) {
            myToolTip_tt.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }
        
        public IMyToolTip setWidth(int _width) {
            myToolTip_tt.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myToolTip_tt.Width;
        }

        public IMyToolTip setMaxWidth(int _maxWidth) {
            myToolTip_tt.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myToolTip_tt.MaxWidth;
        }

        public IMyToolTip setHeight(int _height) {
            myToolTip_tt.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myToolTip_tt.Height;
        }

        public IMyToolTip setMaxHeight(int _maxHeight) {
            myToolTip_tt.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myToolTip_tt.MaxHeight;
        }

        public IMyToolTip setDropShadow(bool _value) {
            myToolTip_tt.HasDropShadow = _value;
            return this;
        }
        public bool hasDropShadow() {
            return myToolTip_tt.HasDropShadow;
        }

        #endregion

        #region event-handler
        
        public IMyToolTip addOnToolTipOpening(IMyController _controller, string _methodName) {
            myToolTip_tt.ToolTipOpening += delegate (object sender, ToolTipEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyToolTip addOnClosed(IMyController _controller, string _methodName) {
            myToolTip_tt.Closed += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        #endregion

        #region set-field

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            mySolidColorBrush = _mySolidColorBrush;
        }

        #endregion
    }
}
