using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyFramework.ui_elements.list_box
{
    internal class MyListBox : IMyListBox, IMyListBoxInjector
    {
        private ListBox myListBox_lb;
        private IMySolidColorBrush mySolidColorBrush;
        internal MyListBox(Object _deployedListBox) {
            myListBox_lb = (ListBox)_deployedListBox;
         }

        #region properties
        public IMyListBox setTooltip(string _tooltip)
        {
            myListBox_lb.ToolTip = _tooltip;
            return this;
        }

        public IMyListBox setFontWeight(MyFontWeight myFontWeight)
        {
            myListBox_lb.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyListBox setFontStretch(MyFontStretch myFontStretch)
        {
            myListBox_lb.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyListBox setFontSize(int _fontSize) {
            myListBox_lb.FontSize = _fontSize;
            return this;
        }

        public IMyListBox setFontStyle(MyFontStyle myFontStyle) {
            myListBox_lb.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyListBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myListBox_lb.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyListBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myListBox_lb.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyListBox addItem(string _item) {
            myListBox_lb.Items.Add(_item);
            return this;
        }
        public string getSelectedItem() {
            return myListBox_lb.SelectedItem.ToString();
        }
        
        public int getSelectedItemIndex() {
            return myListBox_lb.SelectedIndex;
        }

        public int getNumberOfItems() {
            return myListBox_lb.Items.Count;
        }

        public IMyListBox setItemList(MyList<string> _listOfItem) {
            myListBox_lb.ItemsSource = _listOfItem;
            return this;
        }

        public IMyListBox setHeight(int _height) {
            myListBox_lb.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myListBox_lb.Height;
        }

        public IMyListBox setMaxHeight(int _maxHeight) {
            myListBox_lb.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myListBox_lb.MaxHeight;
        }

        public IMyListBox setWidth(int _width) {
            myListBox_lb.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myListBox_lb.Width;
        }

        public IMyListBox setMaxWidth(int _maxWidth) {
            myListBox_lb.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myListBox_lb.MaxWidth;
        }

        public IMyListBox setBackgroundColor(string _color) {
            myListBox_lb.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyListBox setTextColor(string _color) {
            myListBox_lb.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler

        public IMyListBox addOnSelectionChanged(IMyController _controller, string _methodName) {
            myListBox_lb.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
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
