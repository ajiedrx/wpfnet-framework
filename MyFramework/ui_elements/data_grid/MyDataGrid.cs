using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MyFramework.ui_elements.data_grid
{
    internal class MyDataGrid : IMyDataGrid
    {
        private DataGrid myDataGrid_dg; 
        internal MyDataGrid(Object _deployedDataGrid) {
            myDataGrid_dg = (DataGrid)_deployedDataGrid;
        }

        #region properties
        
        public IMyDataGrid addItemSource<T>(MyList<T> _listItem) {
            foreach(T item in _listItem) {
                myDataGrid_dg.Items.Add(item);
            }
            return this;
        }
        public IMyDataGrid addItem<T>(T _item) {
            myDataGrid_dg.Items.Add(_item);
            return this;
        }
        
        public IMyDataGrid setColumnHeader(string _columnHeader, string _propertyName) {
            DataGridTextColumn dtx = new DataGridTextColumn();
            dtx.Header = _columnHeader;
            dtx.Binding = new Binding(_propertyName);
            myDataGrid_dg.Columns.Add(dtx);
            return this;
        }
        public IMyDataGrid setColumnHeader(MyList<string> _columnHeader, MyList<string> _propertyName) {
            for(int i = 0; i<_columnHeader.Count; i++) {
                DataGridTextColumn dtx = new DataGridTextColumn();
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

        public IMyDataGrid setColumnWidth(int _columnWidth) {
            myDataGrid_dg.ColumnWidth = _columnWidth;
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
