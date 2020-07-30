using MyFramework.basic;
using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace MyFramework.ui_elements.list_view
{
    internal class MyListView : IMyListView, IMyListViewInjector
    {
        private ListView myListView_lv;
        private IMySolidColorBrush mySolidColorBrush;

        internal MyListView(Object _deployedListView) {
            myListView_lv = (ListView)_deployedListView;
        }

        public IMyListView addGridViewColumns(MyList<string> _headers, MyList<string> _propertyNames) {
            GridView gridView = new GridView();
            myListView_lv.View = gridView;
            for (int i = 0; i < _headers.Count; i++) {
                gridView.Columns.Add(new GridViewColumn { 
                    Header = _headers[i], 
                    DisplayMemberBinding = new Binding(_propertyNames[i])
                });
            }
            return this;
        }

        public IMyListView addItems<T>(MyList<T> _items) {
            foreach (T item in _items) {
                myListView_lv.Items.Add(item);
            }
            return this;
        }
        public IMyListView addItem(object _item) {
            myListView_lv.Items.Add(_item);
            return this;
        }

        public IMyListView addItems(MyList<object> _items) {
            foreach (object obj in _items) {
                myListView_lv.Items.Add(obj);
            }
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

        #region event-handler

        public IMyListView addOnSelectionChanged(IMyController _controller, string _methodName) {
            myListView_lv.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _controller.callMethod(_methodName, myListView_lv.SelectedItem);
            };
            return this;
        }

        public IMyListView addOnSelectionChanged(IMyView _view, string _methodName) {
            myListView_lv.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _view.callMethod(_methodName, myListView_lv.SelectedItem);
            };
            return this;
        }
        #endregion
    }
}
