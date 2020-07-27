using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFramework.ui_elements.password_box
{
    internal class MyPasswordBox : IMyPasswordBox, IMyPasswordBoxInjector
    {
        private IMySolidColorBrush mySolidColorBrush;
        private PasswordBox myPasswordBox_pwd;
        internal MyPasswordBox(Object _deployedPasswordBox) {
            myPasswordBox_pwd = (PasswordBox)_deployedPasswordBox;
        }

        #region properties
        public IMyPasswordBox setTooltip(string _tooltip) {
            myPasswordBox_pwd.ToolTip = _tooltip;
            return this;
        }

        public IMyPasswordBox setFontWeight(MyFontWeight myFontWeight) {
            myPasswordBox_pwd.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyPasswordBox setFontStretch(MyFontStretch myFontStretch) {
            myPasswordBox_pwd.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyPasswordBox setFontSize(int _fontSize) {
            myPasswordBox_pwd.FontSize = _fontSize;
            return this;
        }

        public IMyPasswordBox setFontStyle(MyFontStyle myFontStyle) {
            myPasswordBox_pwd.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyPasswordBox setPasswordVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myPasswordBox_pwd.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyPasswordBox setPasswordHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myPasswordBox_pwd.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyPasswordBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myPasswordBox_pwd.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyPasswordBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myPasswordBox_pwd.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyPasswordBox setPassword(string _Password) {
            myPasswordBox_pwd.Password = _Password;
            return this;
        }
        public String getPassword() {
            return myPasswordBox_pwd.Password.ToString();
        }

        public IMyPasswordBox setChar(char _char) {
            myPasswordBox_pwd.PasswordChar = _char;
            return this;
        }

        public IMyPasswordBox setMaxLength(int _maxLength) {
            myPasswordBox_pwd.MaxLength = _maxLength;
            return this;
        }

        public IMyPasswordBox setWidth(int _width) {
            myPasswordBox_pwd.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myPasswordBox_pwd.Width;
        }

        public IMyPasswordBox setMaxWidth(int _maxWidth) {
            myPasswordBox_pwd.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myPasswordBox_pwd.MaxWidth;
        }

        public IMyPasswordBox setHeight(int _height) {
            myPasswordBox_pwd.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myPasswordBox_pwd.Height;
        }

        public IMyPasswordBox setMaxHeight(int _maxHeight) {
            myPasswordBox_pwd.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myPasswordBox_pwd.MaxHeight;
        }
        public IMyPasswordBox setBackgroundColor(string _color) {
            myPasswordBox_pwd.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyPasswordBox setTextColor(string _color) {
            myPasswordBox_pwd.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler
        public IMyPasswordBox addOnTextChanged(IMyController _controller, string _methodName) {
            myPasswordBox_pwd.PasswordChanged += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyPasswordBox addOnGotFocus(IMyController _controller, string _methodName) {
            myPasswordBox_pwd.GotFocus += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyPasswordBox addOnPreviewMouseDown(IMyController _controller, string _methodName) {
            myPasswordBox_pwd.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
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
