using System.Windows.Input;
using Velacro.Basic;
using Velacro.Enums;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.TextBlock {
    internal class MyTextBlock : MyUIElements, IMyTextBlock
    {
        private System.Windows.Controls.TextBlock myTextBlock_tb;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyTextBlock(object _uiElement) : base((System.Windows.Controls.TextBlock)_uiElement) {
            myTextBlock_tb = (System.Windows.Controls.TextBlock)_uiElement;
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
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the text alignment.
        /// </summary>
        /// <param name="_myTextAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyTextAlignment"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setTextAlignment(MyTextAlignment _myTextAlignment) {
            myTextBlock_tb.TextAlignment = _myTextAlignment.getTextAlignment();
            return this;
        }
        /// <summary>
        /// Set the text wrapping
        /// </summary>
        /// <param name="myTextWrapping">A MyTextWrapping param.</param>
        /// <returns></returns>
        public IMyTextBlock setTextWrapping(MyTextWrapping _myTextWrapping) {
            myTextBlock_tb.TextWrapping = _myTextWrapping.getTextWrapping();
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setTextVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the width of the TextBlock.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the TextBlock.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the TextBlock max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the TextBlock.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the TextBlock height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the TextBlock.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the TextBlock max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the TextBlock max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
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
        public IMyTextBlock setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the TextBlock text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
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
            base.setBackgroundImage(_path);
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
