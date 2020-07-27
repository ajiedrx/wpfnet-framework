using MyFramework.basic;
using MyFramework.enums;
using MyFramework.ui_elements.combo_box;
using System;
using System.Windows.Controls;

namespace MyFramework.ui_elements.combo_box
{
    internal class MyComboBox : IMyComboBox, IMyComboBoxInjector
    {
        private ComboBox myComboBox_cbo;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyComboBox(Object _deployedComboBox) {
            myComboBox_cbo = (ComboBox)_deployedComboBox; 
        }

        #region properties
        public IMyComboBox setTooltip(string _tooltip) {
            myComboBox_cbo.ToolTip = _tooltip;
            return this;
        }

        public IMyComboBox setFontWeight(MyFontWeight myFontWeight) {
            myComboBox_cbo.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyComboBox setFontStretch(MyFontStretch myFontStretch) {
            myComboBox_cbo.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyComboBox setFontSize(int _fontSize) {
            myComboBox_cbo.FontSize = _fontSize;
            return this;
        }

        public IMyComboBox setFontStyle(MyFontStyle myFontStyle) {
            myComboBox_cbo.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyComboBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myComboBox_cbo.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyComboBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myComboBox_cbo.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyComboBox setSelectedItem(string _itemName) {
            myComboBox_cbo.SelectedItem = _itemName;
            return this;
        }
        public string getSelectedItem() {
            return myComboBox_cbo.SelectedItem.ToString();
        }
        
        public IMyComboBox setSelectedItemIndex(int _itemIndex) {
            myComboBox_cbo.SelectedIndex = _itemIndex;
            return this;
        }
        public int getSelectedItemIndex() {
            return myComboBox_cbo.SelectedIndex;
        }

        public bool isDropDownOpen() {
            return myComboBox_cbo.IsDropDownOpen;
        }

        public IMyComboBox addItem(string _item) {
            myComboBox_cbo.Items.Add(_item);
            myComboBox_cbo.SelectedIndex = 0;
            return this;
        }

        public IMyComboBox setHeight(int _height) {
            myComboBox_cbo.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myComboBox_cbo.Height;
        }

        public IMyComboBox setMaxHeight(int _maxHeight) {
            myComboBox_cbo.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myComboBox_cbo.MaxHeight;
        }

        public IMyComboBox setWidth(int _width) {
            myComboBox_cbo.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myComboBox_cbo.Width;
        }

        public IMyComboBox setMaxWidth(int _maxWidth) {
            myComboBox_cbo.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myComboBox_cbo.MaxWidth;
        }

        public IMyComboBox setBackgroundColor(string _color) {
            myComboBox_cbo.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyComboBox setTextColor(string _color) {
            myComboBox_cbo.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyComboBox setItemList(MyList<string> _listOfItem) {
            myComboBox_cbo.ItemsSource = _listOfItem;
            myComboBox_cbo.SelectedIndex = 0;
            return this;
        }

        #endregion

        #region event-handler

        public IMyComboBox addOnDropDownOpened(IMyController _controller, string _methodName) {
            myComboBox_cbo.DropDownOpened += delegate (object sender, EventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        public IMyComboBox addOnDropDownClosed(IMyController _controller, string _methodName) {
            myComboBox_cbo.DropDownClosed += delegate (object sender, EventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }
        public IMyComboBox addOnSelectionChanged(IMyController _controller, string _methodName) {
            myComboBox_cbo.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
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
