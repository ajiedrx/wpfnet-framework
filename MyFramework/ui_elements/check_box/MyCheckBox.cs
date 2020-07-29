using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyFramework.ui_elements.check_box {
    internal class MyCheckBox : IMyCheckBox, IMyCheckBoxInjector
    {
        private CheckBox myCheckBox_chk;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyCheckBox(Object _deployedCheckBox) {
            myCheckBox_chk = (CheckBox)_deployedCheckBox;
        }

        #region properties

        public bool isChecked() {
            return (bool)myCheckBox_chk.IsChecked;
        }

        public IMyCheckBox setTooltip(string _tooltip) {
            myCheckBox_chk.ToolTip = _tooltip;
            return this;
        }

        public IMyCheckBox setFontWeight(MyFontWeight myFontWeight) {
            myCheckBox_chk.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyCheckBox setFontStretch(MyFontStretch myFontStretch) {
            myCheckBox_chk.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyCheckBox setFontSize(int _fontSize) {
            myCheckBox_chk.FontSize = _fontSize;
            return this;
        }

        public IMyCheckBox setFontStyle(MyFontStyle myFontStyle) {
            myCheckBox_chk.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyCheckBox setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myCheckBox_chk.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyCheckBox setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myCheckBox_chk.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyCheckBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myCheckBox_chk.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyCheckBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myCheckBox_chk.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyCheckBox setText(string _text) {
            myCheckBox_chk.Content = _text;
            return this;
        }
        
        public IMyCheckBox setWidth(int _width)
        {
            myCheckBox_chk.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myCheckBox_chk.Width;
        }

        public IMyCheckBox setMaxWidth(int _maxWidth) {
            myCheckBox_chk.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myCheckBox_chk.MaxWidth;
        }

        public IMyCheckBox setHeight(int _height) {
            myCheckBox_chk.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myCheckBox_chk.Height;
        }

        public IMyCheckBox setMaxHeight(int _maxHeight) {
            myCheckBox_chk.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myCheckBox_chk.MaxHeight;
        }

        public IMyCheckBox setBackgroundColor(string _color) {
            myCheckBox_chk.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyCheckBox setTextColor(string _color) {
            myCheckBox_chk.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler

        public IMyCheckBox addOnClick(IMyController _controller, string _methodName) {
            myCheckBox_chk.Click += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyCheckBox addOnChecked(IMyController _controller, string _methodName) {
            myCheckBox_chk.Checked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyCheckBox addOnUnchecked(IMyController _controller, string _methodName) {
            myCheckBox_chk.Unchecked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyCheckBox addOnClick(IMyView _view, string _methodName) {
            myCheckBox_chk.Click += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }

        public IMyCheckBox addOnChecked(IMyView _view, string _methodName) {
            myCheckBox_chk.Checked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }

        public IMyCheckBox addOnUnchecked(IMyView _view, string _methodName) {
            myCheckBox_chk.Unchecked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
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
