using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFramework.ui_elements.text_block {
    internal class MyTextBlock : IMyTextBlock, IMyTextBlockInjector
    {
        private TextBlock myTextBlock_tb;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyTextBlock(Object _deployedTextBlock) {
            myTextBlock_tb = (TextBlock)_deployedTextBlock;
        }

        #region properties
        public IMyTextBlock setTooltip(string _tooltip) {
            myTextBlock_tb.ToolTip = _tooltip;
            return this;
        }

        public IMyTextBlock setFontWeight(MyFontWeight myFontWeight) {
            myTextBlock_tb.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyTextBlock setFontStretch(MyFontStretch myFontStretch) {
            myTextBlock_tb.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyTextBlock setFontSize(int _fontSize) {
            myTextBlock_tb.FontSize = _fontSize;
            return this;
        }

        public IMyTextBlock setFontStyle(MyFontStyle myFontStyle) {
            myTextBlock_tb.FontStyle = myFontStyle.getFontStyle();
            return this;
        }
        
        public IMyTextBlock setTextAlignment(MyTextAlignment myTextAlignment) {
            myTextBlock_tb.TextAlignment = myTextAlignment.getTextAlignment();
            return this;
        }

        public IMyTextBlock setTextWrapping(MyTextWrapping myTextWrapping) {
            myTextBlock_tb.TextWrapping = myTextWrapping.getTextWrapping();
            return this;
        }

        public IMyTextBlock setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myTextBlock_tb.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }
        
        public IMyTextBlock setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myTextBlock_tb.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyTextBlock setWidth(int _width) {
            myTextBlock_tb.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myTextBlock_tb.Width;
        }

        public IMyTextBlock setMaxWidth(int _maxWidth) {
            myTextBlock_tb.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myTextBlock_tb.MaxWidth;
        }

        public IMyTextBlock setHeight(int _height) {
            myTextBlock_tb.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myTextBlock_tb.Height;
        }

        public IMyTextBlock setMaxHeight(int _maxHeight) {
            myTextBlock_tb.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myTextBlock_tb.MaxHeight;
        }

        public IMyTextBlock setText(string _text) {
            myTextBlock_tb.Text = _text;
            return this;
        }

        public IMyTextBlock setBackgroundColor(string _color) {
            myTextBlock_tb.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyTextBlock setTextColor(string _color) {
            myTextBlock_tb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler
        public IMyTextBlock addOnPreviewMouseDown(IMyController _controller, string _methodName) {
            myTextBlock_tb.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        #endregion

        #region set-field

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            this.mySolidColorBrush = _mySolidColorBrush;
        }

        #endregion
    }
}
