using Velacro.Basic;
using Velacro.Enums;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.CheckBox {

    /// <summary>
    /// The main CheckBox class.
    /// Contains methods for CheckBox element manipulation.
    /// </summary>
    internal class MyCheckBox : MyUIElements, IMyCheckBox
    {
        private System.Windows.Controls.CheckBox myCheckBox_chk;
        internal MyCheckBox(object _uiElement) : base((System.Windows.Controls.CheckBox)_uiElement){
            myCheckBox_chk = (System.Windows.Controls.CheckBox)_uiElement;
        }

        #region properties
        /// <summary>
        /// Get the status of CheckBox
        /// </summary>
        /// <returns>bool</returns>
        public bool isChecked() {
            return (bool)myCheckBox_chk.IsChecked;
        }
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyCheckBox
        /// </returns>
        public IMyCheckBox setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the text vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setTextVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setTextHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text on the CheckBox.
        /// </summary>
        /// <param name="_text">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setText(string _text) {
            myCheckBox_chk.Content = _text;
            return this;
        }
        /// <summary>
        /// Set the width of the CheckBox.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setWidth(int _width)
        {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the CheckBox.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the CheckBox max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the CheckBox.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the CheckBox height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        public IMyCheckBox setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the CheckBox.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the CheckBox max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the CheckBox max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the CheckBox background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the CheckBox text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the CheckBox background image.
        /// </summary>
        /// <param name="_path">A string param.</param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox setBackgroundImage(string _path) {
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
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox addOnClick(IMyController _controller, string _methodName) {
            myCheckBox_chk.Click += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onChecked listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox addOnChecked(IMyController _controller, string _methodName) {
            myCheckBox_chk.Checked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onUnchecked listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox addOnUnchecked(IMyController _controller, string _methodName) {
            myCheckBox_chk.Unchecked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// OVERLOAD Add onClick listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox addOnClick(IMyView _view, string _methodName) {
            myCheckBox_chk.Click += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// OVERLOAD Add onChecked listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox addOnChecked(IMyView _view, string _methodName) {
            myCheckBox_chk.Checked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// OVERLOAD Add onUnchecked listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox addOnUnchecked(IMyView _view, string _methodName) {
            myCheckBox_chk.Unchecked += delegate (object sender, System.Windows.RoutedEventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }

        #endregion
    }
}
