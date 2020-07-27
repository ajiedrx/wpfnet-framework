using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyFramework.ui_elements.radio_button
{
    internal class MyRadioButton : IMyRadioButton, IMyRadioButtonInjector
    {
        private RadioButton myRadioButton_rdo;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyRadioButton(Object _developedRadioButton) {
            myRadioButton_rdo = (RadioButton)_developedRadioButton;
        }

        #region properties
        public IMyRadioButton setTooltip(string _tooltip) {
            myRadioButton_rdo.ToolTip = _tooltip;
            return this;
        }

        public IMyRadioButton setFontWeight(MyFontWeight myFontWeight) {
            myRadioButton_rdo.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyRadioButton setFontStretch(MyFontStretch myFontStretch) {
            myRadioButton_rdo.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyRadioButton setFontSize(int _fontSize) {
            myRadioButton_rdo.FontSize = _fontSize;
            return this;
        }

        public IMyRadioButton setFontStyle(MyFontStyle myFontStyle) {
            myRadioButton_rdo.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyRadioButton setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myRadioButton_rdo.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyRadioButton setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myRadioButton_rdo.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyRadioButton setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myRadioButton_rdo.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyRadioButton setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myRadioButton_rdo.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyRadioButton setValue(bool _value) {
            myRadioButton_rdo.IsChecked = _value;
            return this;
        }

        public bool getValue() {
            return (bool)myRadioButton_rdo.IsChecked;
        }

        public IMyRadioButton setText(string _text) {
            myRadioButton_rdo.Content = _text;
            return this;
        }

        public IMyRadioButton setWidth(int _width) {
            myRadioButton_rdo.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myRadioButton_rdo.Width;
        }

        public IMyRadioButton setMaxWidth(int _maxWidth) {
            myRadioButton_rdo.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myRadioButton_rdo.MaxWidth;
        }

        public IMyRadioButton setHeight(int _height) {
            myRadioButton_rdo.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myRadioButton_rdo.Height;
        }

        public IMyRadioButton setMaxHeight(int _maxHeight) {
            myRadioButton_rdo.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myRadioButton_rdo.MaxHeight;
        }

        public IMyRadioButton setBackgroundColor(string _color) {
            myRadioButton_rdo.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyRadioButton setTextColor(string _color) {
            myRadioButton_rdo.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler

        public IMyRadioButton addOnClick(IMyController _controller, string _methodName) {
            myRadioButton_rdo.Click += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        
        public IMyRadioButton addOnChecked(IMyController _controller, string _methodName) {
            myRadioButton_rdo.Checked += delegate (object sender, System.Windows.RoutedEventArgs e) {
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
