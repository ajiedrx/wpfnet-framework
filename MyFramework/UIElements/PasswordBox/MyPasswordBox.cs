using System.Windows;
using System.Windows.Input;
using Velacro.Basic;
using Velacro.Enums;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.PasswordBox
{
    internal class MyPasswordBox : MyUIElements, IMyPasswordBox
    {
        private System.Windows.Controls.PasswordBox myPasswordBox_pwd;
        internal MyPasswordBox(object _uiElement) : base((System.Windows.Controls.PasswordBox)_uiElement) {
            myPasswordBox_pwd = (System.Windows.Controls.PasswordBox)_uiElement;
        }
        #region properties
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyPasswordBox
        /// </returns>
        public IMyPasswordBox setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the text vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setPasswordVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setTextVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setPasswordHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setTextHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the password string.
        /// </summary>
        /// <param name="_Password">A string param.</param>
        /// <returns></returns>
        public IMyPasswordBox setPassword(string _Password) {
            myPasswordBox_pwd.Password = _Password;
            return this;
        }
        /// <summary>
        /// Get the password string.
        /// </summary>
        /// <returns></returns>
        public string getPassword() {
            return myPasswordBox_pwd.Password.ToString();
        }
        /// <summary>
        /// Set the password hiding chars.
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public IMyPasswordBox setChar(char _char) {
            myPasswordBox_pwd.PasswordChar = _char;
            return this;
        }
        /// <summary>
        /// Set the max length of the characters.
        /// </summary>
        /// <param name="_maxLength"></param>
        /// <returns></returns>
        public IMyPasswordBox setMaxLength(int _maxLength) {
            myPasswordBox_pwd.MaxLength = _maxLength;
            return this;
        }
        /// <summary>
        /// Set the width of the PasswordBox.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the PasswordBox.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the PasswordBox max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the PasswordBox.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the PasswordBox height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the PasswordBox.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the PasswordBox max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the PasswordBox max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the PasswordBox background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the PasswordBox text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }

        /// <summary>
        /// Set the background image.
        /// </summary>
        /// <remarks>Image build action must be set to Resource.</remarks>
        /// <param name="_path">A string image path param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }

        #endregion

        #region event-handler
        /// <summary>
        /// Add onTextChanged listener. 
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox addOnTextChanged(IMyController _controller, string _methodName) {
            myPasswordBox_pwd.PasswordChanged += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        /// <summary>
        /// Add onTextChanged listener. 
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox addOnTextChanged(IMyView _view, string _methodName) {
            myPasswordBox_pwd.PasswordChanged += delegate (object sender, RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onGotFocus listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns></returns>
        public IMyPasswordBox addOnGotFocus(IMyController _controller, string _methodName) {
            myPasswordBox_pwd.GotFocus += delegate (object sender, RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        /// <summary>
        /// Add onGotFocus listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns></returns>
        public IMyPasswordBox addOnGotFocus(IMyView _view, string _methodName) {
            myPasswordBox_pwd.GotFocus += delegate (object sender, RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onPreviewMouseDown listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns></returns>
        public IMyPasswordBox addOnPreviewMouseDown(IMyController _controller, string _methodName) {
            myPasswordBox_pwd.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        /// <summary>
        /// Add onPreviewMouseDown listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns></returns>
        public IMyPasswordBox addOnPreviewMouseDown(IMyView _view, string _methodName) {
            myPasswordBox_pwd.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        #endregion
    }
}
