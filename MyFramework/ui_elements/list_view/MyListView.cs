using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyFramework.ui_elements.list_view
{
    internal class MyListView : IMyListView, IMyListViewInjector
    {
        private ListView myListView_lv;
        private IMySolidColorBrush mySolidColorBrush;

        internal MyListView(Object _deployedListView) {
            myListView_lv = (ListView)_deployedListView;
        }

        public IMyListView addItem(object _item) {
            myListView_lv.Items.Add(_item);
            return this;
        }

        public int getNumberOfItems() {
            return myListView_lv.Items.Count;
        }

        public string getSelectedItem() {
            return myListView_lv.SelectedItem.ToString();
        }

        public IMyListView setHeight(int _height) {
            myListView_lv.Height = _height;
            return this;
        }

        public IMyListView setWidth(int _width) {
            myListView_lv.Width = _width;
            return this;
        }

        public IMyListView setBackgroundColor(string _color) {
            myListView_lv.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyListView setTextColor(string _color) {
            myListView_lv.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            this.mySolidColorBrush = _mySolidColorBrush;
        }
    }
}
