using System.Windows.Controls;
using System.Windows.Data;
using Velacro.Basic;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.ListView
{
    internal class MyListView : MyUIElements, IMyListView
    {
        private System.Windows.Controls.ListView myListView_lv;

        internal MyListView(object _uiElement) : base((System.Windows.Controls.ListView)_uiElement) {
            myListView_lv = (System.Windows.Controls.ListView)_uiElement;
        }
        /// <summary>
        /// Add GridViewColumn to ListView
        /// </summary>
        /// <param name="_headers">A MyList of string param.</param>
        /// <param name="_propertyNames">A MyList of string param.</param>
        /// <returns>IMyListView</returns>
        public IMyListView addGridViewColumns(MyList<string> _headers, MyList<string> _propertyNames) {
            GridView gridView = new GridView();
            myListView_lv.View = gridView;
            for (int i = 0; i < _headers.Count; i++) {
                gridView.Columns.Add(new GridViewColumn { 
                    Header = _headers[i], 
                    DisplayMemberBinding = new Binding(_propertyNames[i]),
                });
            }
            return this;
        }
        /// <summary>
        /// Add items to ListView within GridViewColumn.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_items"></param>
        /// <returns></returns>
        public IMyListView addItems<T>(MyList<T> _items) {
            foreach (T item in _items) {
                myListView_lv.Items.Add(item);
            }
            return this;
        }
        /// <summary>
        /// Add item to ListView within GridViewColumn.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_item"></param>
        /// <returns></returns>
        public IMyListView addItem<T>(T _item) {
            myListView_lv.Items.Add(_item);
            return this;
        }
        /// <summary>
        /// Get total number of items.
        /// </summary>
        /// <returns>int</returns>
        public int getNumberOfItems() {
            return myListView_lv.Items.Count;
        }
        /// <summary>
        /// Get the selected item.
        /// </summary>
        /// <returns>object</returns>
        public object getSelectedItem() {
            return myListView_lv.SelectedItem;
        }
        /// <summary>
        /// Set the ListView height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyListView
        /// </returns>
        public IMyListView setTooltip(string _tooltip) {
            base.setTooltip(_tooltip);
            return this;
        }
        /// <summary>
        /// Get the height of the ListView.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the ListView max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the ListView max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the width of the ListView.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the ListView.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the ListView max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the ListView.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the ListView background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }

        /// <summary>
        /// Set the ListView background image.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }

        /// <summary>
        /// Set the ListView text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyListView</returns>
        public IMyListView setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }
        #region event-handler
        /// <summary>
        /// Add onSelectionChanged listener. 
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyListView</returns>
        public IMyListView addOnSelectionChanged(IMyController _controller, string _methodName) {
            myListView_lv.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _controller.callMethod(_methodName, myListView_lv.SelectedItem);
            };
            return this;
        }
        /// <summary>
        /// Add onSelectionChanged listener. 
        /// </summary>
        /// <param name="_view"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyListView</returns>
        public IMyListView addOnSelectionChanged(IMyView _view, string _methodName) {
            myListView_lv.SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _view.callMethod(_methodName, myListView_lv.SelectedItem);
            };
            return this;
        }
        #endregion
    }
}
