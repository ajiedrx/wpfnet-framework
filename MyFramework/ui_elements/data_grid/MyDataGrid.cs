using MyFramework.basic;
using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace MyFramework.ui_elements.data_grid
{
    internal class MyDataGrid : IMyDataGrid
    {
        private DataGrid myDataGrid_dg; 
        internal MyDataGrid(Object _deployedDataGrid) {
            myDataGrid_dg = (DataGrid)_deployedDataGrid;
            myDataGrid_dg.AutoGenerateColumns = false;
        }

        #region properties
        //doesntwork
        public IMyDataGrid addItemSource<T>(MyList<T> _listItem) {
            foreach(T item in _listItem) {
                myDataGrid_dg.Items.Add(item);
            }
            return this;
        }
        //doesntwork
        public IMyDataGrid addItem<T>(T _item) {
            myDataGrid_dg.Items.Add(_item);
            return this;
        }
        //deletesoon
        public IMyDataGrid setColumnHeader(string _columnHeader, string _propertyName) {
            DataGridTextColumn dtx = new DataGridTextColumn();
            dtx.Header = _columnHeader;
            dtx.Binding = new Binding(_propertyName);
            myDataGrid_dg.Columns.Add(dtx);
            return this;
        }

        public IMyDataGrid setColumnDataBinding<T>(MyList<string> _columnHeader, MyList<string> _propertyName, MyList<T> _data) {
            for(int i = 0; i<_columnHeader.Count; i++) {
                DataGridTextColumn dtx = new DataGridTextColumn();
                myDataGrid_dg.ItemsSource = _data;
                dtx.Header = _columnHeader[i];
                dtx.Binding = new Binding(_propertyName[i]);
                myDataGrid_dg.Columns.Add(dtx);
            }
            return this;
        }

        public IMyDataGrid setHeight(int _height) {
            myDataGrid_dg.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myDataGrid_dg.Height;
        }

        public IMyDataGrid setMaxHeight(int _maxHeight) {
            myDataGrid_dg.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myDataGrid_dg.MaxHeight;
        }

        public IMyDataGrid setWidth(int _width) {
            myDataGrid_dg.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myDataGrid_dg.Width;
        }

        public IMyDataGrid setMaxWidth(int _maxWidth) {
            myDataGrid_dg.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myDataGrid_dg.MaxWidth;
        }

        #region column-width

        public IMyDataGrid setAllColumnWidth(int _columnWidth) {
            myDataGrid_dg.ColumnWidth = _columnWidth;
            return this;
        }

        public IMyDataGrid setAllColumnWidth(DataGridLength _columnWidth) {
            myDataGrid_dg.ColumnWidth = _columnWidth;
            return this;
        }

        public IMyDataGrid setOneColumnWidth(string _header, int _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.Width = _width;
                }
            }
            return this;
        }

        public IMyDataGrid setOneColumnWidth(string _header, DataGridLength _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.Width = _width;
                }
            }
            return this;
        }

        public IMyDataGrid setOneColumnMaxWidth(string _header, int _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.MaxWidth = _width;
                }
            }
            return this;
        }

        public IMyDataGrid setOneColumnMinWidth(string _header, int _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.MinWidth = _width;
                }
            }
            return this;
        }

        public IMyDataGrid setMaxColumnWidth(int _columnMaxWidth) {
            myDataGrid_dg.ColumnWidth = _columnMaxWidth; 
            return this;
        }

        #endregion


        #endregion
    }
}
