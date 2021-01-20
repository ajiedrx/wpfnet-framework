using System;
using System.Windows;
using System.Windows.Input;
using Velacro.Basic;
using Velacro.Enums;
using Velacro.UIElements.Basic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace Velacro.UIElements.TextBlock {
    internal class MyTextBlock : IMyTextBlock
    {
        private System.Windows.Controls.TextBlock myTextBlock_tb;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyTextBlock(object _uiElement) {
            myTextBlock_tb = (System.Windows.Controls.TextBlock)_uiElement;
            mySolidColorBrush = new MySolidColorBrush();
        }

        #region properties
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyTextBlock
        /// </returns>
        public IMyTextBlock setTooltip(string _tooltip) {
            myTextBlock_tb.ToolTip = _tooltip;
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontWeight(MyFontWeight _myFontWeight) {
            myTextBlock_tb.FontWeight = _myFontWeight.getFontWeight();
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontStretch(MyFontStretch myFontStretch) {
            myTextBlock_tb.FontStretch = myFontStretch.getFontStretch();
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontSize(int _fontSize) {
            myTextBlock_tb.FontSize = _fontSize;
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontStyle(MyFontStyle myFontStyle) {
            myTextBlock_tb.FontStyle = myFontStyle.getFontStyle();
            return this;
        }
        /// <summary>
        /// Set the text alignment.
        /// </summary>
        /// <param name="_myTextAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyTextAlignment"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setTextAlignment(MyTextAlignment myTextAlignment) {
            myTextBlock_tb.TextAlignment = myTextAlignment.getTextAlignment();
            return this;
        }
        /// <summary>
        /// Set the text wrapping
        /// </summary>
        /// <param name="myTextWrapping">A MyTextWrapping param.</param>
        /// <returns></returns>
        public IMyTextBlock setTextWrapping(MyTextWrapping myTextWrapping) {
            myTextBlock_tb.TextWrapping = myTextWrapping.getTextWrapping();
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myTextBlock_tb.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myTextBlock_tb.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }
        /// <summary>
        /// Set the width of the TextBlock.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setWidth(int _width) {
            myTextBlock_tb.Width = _width;
            return this;
        }
        /// <summary>
        /// Get the width of the TextBlock.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return (int)myTextBlock_tb.Width;
        }
        /// <summary>
        /// Set the TextBlock max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setMaxWidth(int _maxWidth) {
            myTextBlock_tb.MaxWidth = _maxWidth;
            return this;
        }
        /// <summary>
        /// Get the max width of the TextBlock.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return (int)myTextBlock_tb.MaxWidth;
        }
        /// <summary>
        /// Set the TextBlock height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setHeight(int _height) {
            myTextBlock_tb.Height = _height;
            return this;
        }
        /// <summary>
        /// Get the height of the TextBlock.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return (int)myTextBlock_tb.Height;
        }
        /// <summary>
        /// Set the TextBlock max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setMaxHeight(int _maxHeight) {
            myTextBlock_tb.MaxHeight = _maxHeight;
            return this;
        }
        /// <summary>
        /// Get the TextBlock max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return (int)myTextBlock_tb.MaxHeight;
        }
        /// <summary>
        /// Set the text on the TextBlock.
        /// </summary>
        /// <param name="_text">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setText(string _text) {
            myTextBlock_tb.Text = _text;
            return this;
        }
        /// <summary>
        /// Set the TextBlock background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setBackgroundColor(string _color) {
            myTextBlock_tb.Background = mySolidColorBrush.convertFromHex(_color);
            return this;
        }
        /// <summary>
        /// Set the TextBlock text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setTextColor(string _color) {
            myTextBlock_tb.Foreground = mySolidColorBrush.convertFromHex(_color);
            return this;
        }

        /// <summary>
        /// Set the background image.
        /// </summary>
        /// <remarks>Image build action must be set to Resource.</remarks>
        /// <param name="_path">A string image path param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setBackgroundImage(string _path) {
            Uri resourceUri = new Uri(_path, UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;

            myTextBlock_tb.Background = brush;
            return this;
        }

        #endregion

        #region event-handler
        /// <summary>
        /// Add onPreviewMouseDown listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock addOnPreviewMouseDown(IMyController _controller, string _methodName) {
            myTextBlock_tb.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onPreviewMouseDown listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock addOnPreviewMouseDown(IMyView _view, string _methodName) {
            myTextBlock_tb.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _view.callMethod(_methodName);
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
