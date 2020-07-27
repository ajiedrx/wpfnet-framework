using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace MyFramework.ui_elements.button {
    internal class MyButton : IMyButton, IMyButtonInjector
    {
        private Button myButton_btn;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyButton(Object _deployedButton) {
            myButton_btn = (Button)_deployedButton;
        }

        #region properties

        public IMyButton setTooltip(string _tooltip) {
            myButton_btn.ToolTip = _tooltip;
            return this;
        }

        public IMyButton setFontWeight(MyFontWeight myFontWeight) {
            myButton_btn.FontWeight = myFontWeight.getFontWeight();
            return this;
        }
        
        public IMyButton setFontStretch(MyFontStretch myFontStretch) {
            myButton_btn.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyButton setFontSize(int _fontSize) {
            myButton_btn.FontSize = _fontSize;
            return this;
        }

        public IMyButton setFontStyle(MyFontStyle myFontStyle) {
            myButton_btn.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyButton setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myButton_btn.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyButton setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myButton_btn.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyButton setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myButton_btn.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyButton setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myButton_btn.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyButton setText(string _text) {
            myButton_btn.Content = _text;
            return this;
        }

        public IMyButton setWidth(int _width) {
            myButton_btn.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myButton_btn.Width;
        }

        public IMyButton setMaxWidth(int _maxWidth) {
            myButton_btn.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myButton_btn.MaxWidth;
        }

        public IMyButton setHeight(int _height) {
            myButton_btn.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myButton_btn.Height;
        }

        public IMyButton setMaxHeight(int _maxHeight) {
            myButton_btn.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myButton_btn.MaxHeight;
        }

        public IMyButton setBackgroundColor(string _color) {
            myButton_btn.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyButton setTextColor(string _color) {
            myButton_btn.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyButton setBackgroundImage(string _path) {
            Uri resourceUri = new Uri(_path, UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;

            myButton_btn.Background = brush;
            return this;
        }

        #endregion

        #region event-handler

        public IMyButton addOnClick(IMyController _controller, string _methodName) {
            myButton_btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyButton addOnClick(IMyView _view, string _methodName) {
            myButton_btn.Click += delegate (object sender, RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }

        public IMyButton addOnMouseDown(IMyController _controller, string _methodName) {
            myButton_btn.MouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyButton addOnMouseUp(IMyController _controller, string _methodName) {
            myButton_btn.MouseUp += delegate (object sender, MouseButtonEventArgs e) {
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
