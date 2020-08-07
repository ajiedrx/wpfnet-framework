using MyFramework.basic;
using MyFramework.enums;
using MyFramework.validator;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;

namespace MyFramework.ui_elements.text_box
{
    internal class MyTextBox : MyUIElements, IMyTextBox
    {
        private TextBox myTextBox_txt;
        private IMySolidColorBrush mySolidColorBrush;
        private MyRegex myRegex;

        internal MyTextBox(object _uiElement) : base((TextBox)_uiElement){
            myTextBox_txt = (TextBox)_uiElement;
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
        public IMyTextBox setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBox setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBox setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBox setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBox setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the text vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setTextVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setTextHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text on the button.
        /// </summary>
        /// <param name="_text">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setText(string _text) {
            myTextBox_txt.Text = _text;
            return this;
        }
        /// <summary>
        /// Get the text.
        /// </summary>
        /// <returns>string</returns>
        public string getText() {
            return myTextBox_txt.Text.ToString();
        }
        /// <summary>
        /// Set the width of the button.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setWidth(int _width) {
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
        public IMyTextBox setMaxWidth(int _maxWidth) {
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
        public IMyTextBox setHeight(int _height) {
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
        public IMyTextBox setMaxHeight(int _maxHeight) {
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
        /// Set max length of the chars.
        /// </summary>
        /// <param name="_maxLength"></param>
        /// <returns></returns>
        public IMyTextBox setMaxLength(int _maxLength){
            myTextBox_txt.MaxLength = _maxLength;
            return this;
        }
        /// <summary>
        /// Set the button background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the button text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyButton</returns>
        public IMyTextBox setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the background image.
        /// </summary>
        /// <remarks>Image build action must be set to Resource.</remarks>
        /// <param name="_path">A string image path param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }

        #endregion

        #region event-handler
        /// <summary>
        /// Set the input validation.
        /// </summary>
        /// <param name="_validator">A Validator param.</param>
        /// <returns></returns>
        public IMyTextBox setInputValidation(Validator _validator) {
            myRegex = _validator.getMyRegex();
            return this;
        }
        /// <summary>
        /// Get the input validation status.
        /// </summary>
        /// <returns>bool</returns>
        public bool getInputValidation() {
            return myRegex.IsMatch(getText());
        }

        //private void validationHandler(object sender, TextCompositionEventArgs e) {
        //    e.Handled = myRegex.IsMatch(e.Text);
        //}
        /// <summary>
        /// Add onTextChanged listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox addOnTextChanged(IMyController _controller, string _methodName) {
            myTextBox_txt.TextChanged += delegate (object sender, TextChangedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onGotFocus listener
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox addOnGotFocus(IMyController _controller, string _methodName) {
            myTextBox_txt.GotFocus += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onPreviewMouseDown listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox addOnPreviewMouseDown(IMyController _controller, string _methodName) {
            myTextBox_txt.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        /// <summary>
        /// Add onTextChanged listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox addOnTextChanged(IMyView _view, string _methodName) {
            myTextBox_txt.TextChanged += delegate (object sender, TextChangedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onGotFocus listener
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox addOnGotFocus(IMyView _view, string _methodName) {
            myTextBox_txt.GotFocus += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onPreviewMouseDown listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyTextBox</returns>
        public IMyTextBox addOnPreviewMouseDown(IMyView _view, string _methodName) {
            myTextBox_txt.PreviewMouseDown += delegate (object sender, MouseButtonEventArgs e) {
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
