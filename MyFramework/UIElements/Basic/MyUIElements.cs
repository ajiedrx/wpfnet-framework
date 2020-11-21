using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using Velacro.Enums;

namespace Velacro.UIElements.Basic {
    public class MyUIElements {
        private Control uiElement;
        private MySolidColorBrush mySolidColorBrush;
        public MyUIElements(object _uiElement) {
            uiElement = (Control)_uiElement;
            mySolidColorBrush = new MySolidColorBrush();
        }
        public void setTooltip(string _tooltip) {
            uiElement.ToolTip = _tooltip;
        }

        public void setFontWeight(MyFontWeight _myFontWeight) {
            uiElement.FontWeight = _myFontWeight.getFontWeight();
        }
        public void setFontStretch(MyFontStretch _myFontStretch) {
            uiElement.FontStretch = _myFontStretch.getFontStretch();
        }
        public void setFontSize(int _fontSize) {
            uiElement.FontSize = _fontSize;
        }
        public void setFontStyle(MyFontStyle _myFontStyle) {
            uiElement.FontStyle = _myFontStyle.getFontStyle();
        }
        public void setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            uiElement.VerticalContentAlignment = _myVerticalAlignment.getVerticalAlignment();
        }
        public void setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            uiElement.HorizontalContentAlignment = _myHorizontalAlignment.getHorizontalAlignment();
        }
        public void setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            uiElement.VerticalAlignment = _myVerticalAlignment.getVerticalAlignment();
        }
        public void setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            uiElement.HorizontalAlignment = _myHorizontalAlignment.getHorizontalAlignment();
        }
        public void setWidth(int _width) {
            uiElement.Width = _width;
        }
        public int getWidth() {
            return (int)uiElement.Width;
        }
        public void setHeight(int _height) {
            uiElement.Height = _height;
        }
        public int getHeight() {
            return (int)uiElement.Height;
        }
        public void setMaxWidth(int _maxWidth) {
            uiElement.MaxWidth = _maxWidth;
        }
        public int getMaxWidth() {
            return (int)uiElement.MaxWidth;
        }
        public void setMaxHeight(int _maxHeight) {
            uiElement.MaxHeight = _maxHeight;
        }
        public int getMaxHeight() {
            return (int)uiElement.MaxHeight;
        }
        public void setBackgroundColor(string _hexColor) {
            uiElement.Background = mySolidColorBrush.convertFromHex(_hexColor);
        }
        public void setBackgroundImage(string _path) {
            Uri resourceUri = new Uri(_path, UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;

            uiElement.Background = brush;
        }
        public void setTextColor(string _hexColor) {
            uiElement.Foreground = mySolidColorBrush.convertFromHex(_hexColor);
        }

    }
}
