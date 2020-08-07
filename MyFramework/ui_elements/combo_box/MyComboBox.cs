using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows.Controls;

namespace MyFramework.ui_elements.combo_box
{
    /// <summary>
    /// The main ComboBox class.
    /// Contains methods for ComboBox element manipulation.
    /// </summary>
    internal class MyComboBox : MyUIElements, IMyComboBox
    {
        private ComboBox myComboBox_cbo;
        internal MyComboBox(object _uiElement) : base((ComboBox) _uiElement) {
            myComboBox_cbo = (ComboBox)_uiElement;
        }
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyComboBox
        /// </returns>
        #region properties
        public IMyComboBox setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set selected item on ComboBox.
        /// </summary>
        /// <param name="_itemName">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setSelectedItem(string _itemName) {
            myComboBox_cbo.SelectedItem = _itemName;
            return this;
        }
        /// <summary>
        /// Get the selected item on ComboBox as string.
        /// </summary>
        /// <returns>string</returns>
        public string getSelectedString() {
            return myComboBox_cbo.SelectedItem.ToString();
        }
        /// <summary>
        /// Get the selected item on ComboBox as object.
        /// </summary>
        /// <returns>string</returns>
        public object getSelectedItem() {
            return myComboBox_cbo.SelectedItem;
        }
        /// <summary>
        /// Set selected item index.
        /// </summary>
        /// <param name="_itemIndex">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setSelectedItemIndex(int _itemIndex) {
            myComboBox_cbo.SelectedIndex = _itemIndex;
            return this;
        }
        /// <summary>
        /// Get status of the dropdown.
        /// </summary>
        /// <returns>bool</returns>
        public bool isDropDownOpen() {
            return myComboBox_cbo.IsDropDownOpen;
        }
        /// <summary>
        /// Add one item to ComboBox.
        /// </summary>
        /// <param name="_item">An generic param.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addItem<T>(T _item) {
            myComboBox_cbo.Items.Add(_item);
            myComboBox_cbo.SelectedIndex = 0;
            return this;
        }
        /// <summary>
        /// Add items to ComboBox.
        /// </summary>
        /// <param name="_item">A list of generic data type param.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addItems<T>(MyList<T> _item) {
            myComboBox_cbo.Items.Add(_item);
            myComboBox_cbo.SelectedIndex = 0;
            return this;
        }
        /// <summary>
        /// Set the ComboBox height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        public IMyComboBox setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the ComboBox.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the ComboBox max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the ComboBox max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the width of the ComboBox.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the ComboBox.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the ComboBox max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the ComboBox.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the ComboBox background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the ComboBox text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }
        #endregion

        #region event-handler
        /// <summary>
        /// Add onDropDownOpened listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addOnDropDownOpened(IMyController _controller, string _methodName) {
            myComboBox_cbo.DropDownOpened += delegate (object sender, EventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onDropDownClosed listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addOnDropDownClosed(IMyController _controller, string _methodName) {
            myComboBox_cbo.DropDownClosed += delegate (object sender, EventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onSelectionChanged listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addOnSelectionChanged(IMyController _controller, string _methodName) {
            myComboBox_cbo.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _controller.callMethod(_methodName, ((sender as ComboBox).SelectedItem as ComboBoxItem));
            };
            return this;
        }
        /// <summary>
        /// Add onDropDownOpened listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addOnDropDownOpened(IMyView _view, string _methodName) {
            myComboBox_cbo.DropDownOpened += delegate (object sender, EventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onDropDownClosed listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addOnDropDownClosed(IMyView _view, string _methodName) {
            myComboBox_cbo.DropDownClosed += delegate (object sender, EventArgs e) {
                _view.callMethod(_methodName);
            };
            return this;
        }
        /// <summary>
        /// Add onSelectionChanged listener.
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox addOnSelectionChanged(IMyView _view, string _methodName) {
            myComboBox_cbo.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _view.callMethod(_methodName, ((sender as ComboBox).SelectedItem as ComboBoxItem));
            };
            return this;
        }

        #endregion

        #region get-field
        /// <summary>
        /// Get the selected item index.
        /// </summary>
        /// <returns>int</returns>
        public int getSelectedItemIndex() {
            return myComboBox_cbo.SelectedIndex;
        }
        #endregion
    }
}
