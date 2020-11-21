using System.Windows.Controls;
using Velacro.Basic;
using Velacro.Enums;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.ListBox
{
    internal class MyListBox : MyUIElements, IMyListBox {
        private System.Windows.Controls.ListBox myListBox_lb;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyListBox(object _uiElement) : base((System.Windows.Controls.ListBox)_uiElement) {
            myListBox_lb = (System.Windows.Controls.ListBox)_uiElement;
        }

        #region properties
        /// <summary>
        /// Add one item.
        /// </summary>
        /// <param name="_item">A string param.</param>
        /// <returns>IMyListBox</returns>
        public IMyListBox addItem(string _item) {
            myListBox_lb.Items.Add(_item);
            return this;
        }
        /// <summary>
        /// Add many items.
        /// </summary>
        /// <param name="_listOfItem">A MyList of string param.</param>
        /// <returns></returns>
        public IMyListBox setItemsSource<T>(MyList<T> _listOfItem) {
            myListBox_lb.ItemsSource = _listOfItem;
            return this;
        }
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyListBox
        /// </returns>
        public IMyListBox setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Get the selected item.
        /// </summary>
        /// <returns>string</returns>
        public string getSelectedItem() {
            return myListBox_lb.SelectedItem.ToString();
        }
        /// <summary>
        /// Get the selected items.
        /// </summary>
        /// <returns>MyList of string</returns>
        public MyList<string> getSelectedItems() {
            return (MyList<string>)myListBox_lb.SelectedItems;
        }
        /// <summary>
        /// Get selected item index.
        /// </summary>
        /// <returns>int</returns>
        public int getSelectedItemIndex() {
            return myListBox_lb.SelectedIndex;
        }
        /// <summary>
        /// Get total of the items.
        /// </summary>
        /// <returns></returns>
        public int getNumberOfItems() {
            return myListBox_lb.Items.Count;
        }
        /// <summary>
        /// Set the ListBox height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the ListBox.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the ListBox max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the ListBox max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the width of the ListBox.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the ListBox.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the ListBox max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the ListBox.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the ListBox background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the ListBox background image.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }

        /// <summary>
        /// Set the ListBox text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyListBox</returns>
        public IMyListBox setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }

        #endregion

        #region event-handler
        /// <summary>
        /// Add onSelectionChanged listener. 
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyListBox</returns>
        public IMyListBox addOnSelectionChanged(IMyController _controller, string _methodName) {
            myListBox_lb.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _controller.callMethod(_methodName, myListBox_lb.SelectedItem.ToString());
            };
            return this;
        }
        /// <summary>
        /// Add onSelectionChanged listener. 
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyListBox</returns>
        public IMyListBox addOnSelectionChanged(IMyView _view, string _methodName) {
            myListBox_lb.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _view.callMethod(_methodName, myListBox_lb.SelectedItem.ToString());
            };
            return this;
        }

        #endregion
    }
}
