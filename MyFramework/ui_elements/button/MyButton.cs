using MyFramework.basic;
using MyFramework.enums;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFramework.ui_elements.button {
    /// <summary>
    /// The main Button class.
    /// Contains methods for Button element manipulation.
    /// </summary>
    internal class MyButton : MyUIElements, IMyButton
    {
        private Button myButton_btn;
        internal MyButton(object _uiElement) : base((Button)_uiElement){
            myButton_btn = (Button)_uiElement;
        }

        #region properties
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyButton
        /// </returns>
        public IMyButton setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the text vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setTextVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setTextHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text on the button.
        /// </summary>
        /// <param name="_text">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setText(string _text) {
            myButton_btn.Content = _text;
            return this;
        }
        /// <summary>
        /// Set the width of the button.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the button.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the button max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the button.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the button height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the button.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the button max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the button max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the button background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the button text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the background image.
        /// </summary>
        /// <remarks>Image build action must be set to Resource.</remarks>
        /// <param name="_path">A string image path param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyButton setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }

        #endregion

        #region event-handler
        /// <summary>
        /// Add onClick listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton addOnClick(IMyController _controller, string _methodName) {
            myButton_btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// OVERLOAD Add onClick listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton addOnClick(IMyView _view, string _methodName) {
            myButton_btn.Click += delegate (object sender, RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onMouseDown listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton addOnMouseDown(IMyController _controller, string _methodName) {
            myButton_btn.MouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onMouseUp listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton addOnMouseUp(IMyController _controller, string _methodName) {
            myButton_btn.MouseUp += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onMouseHover listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton addOnMouseHover(IMyController _controller, string _methodName) {
            myButton_btn.MouseEnter += delegate (object sender, MouseEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// OVERLOAD Add onMouseHover listener.
        /// </summary>
        /// <param name=""></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton addOnMouseHover(IMyView _view, string _methodName) {
            myButton_btn.MouseEnter += delegate (object sender, MouseEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        #endregion
    }
}
