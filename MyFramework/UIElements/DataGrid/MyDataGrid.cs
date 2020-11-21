using System.Windows.Controls;
using System.Windows.Data;
using Velacro.Basic;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.DataGrid
{
    /// <summary>
    /// The main DataGrid class.
    /// Contains methods for DataGrid element manipulation.
    /// </summary>
    internal class MyDataGrid : MyUIElements, IMyDataGrid
    {
        private System.Windows.Controls.DataGrid myDataGrid_dg; 
        internal MyDataGrid(object _uiElement) : base((System.Windows.Controls.DataGrid)_uiElement) {
            myDataGrid_dg = (System.Windows.Controls.DataGrid)_uiElement;
            myDataGrid_dg.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Set column headers and property data binding.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_columnHeaders"></param>
        /// <param name="_propertyNames"></param>
        /// <param name="_datas"></param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setColumnDataBinding<T>(MyList<string> _columnHeaders, MyList<string> _propertyNames, MyList<T> _datas) {
            for(int i = 0; i<_columnHeaders.Count; i++) {
                DataGridTextColumn dtx = new DataGridTextColumn();
                myDataGrid_dg.ItemsSource = _datas;
                dtx.Header = _columnHeaders[i];
                dtx.Binding = new Binding(_propertyNames[i]);
                myDataGrid_dg.Columns.Add(dtx);
            }
            return this;
        }
        /// <summary>
        /// Set the DataGrid height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        public IMyDataGrid setHeight(int _height) {
            myDataGrid_dg.Height = _height;
            return this;
        }
        /// <summary>
        /// Get the height of the DataGrid.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the DataGrid max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the DataGrid max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the width of the DataGrid.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the DataGrid.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the DataGrid max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the DataGrid.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }

        /// <summary>
        /// Set all column width.
        /// </summary>
        /// <param name="_columnWidth">An int param.</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setAllColumnWidth(int _columnWidth) {
            myDataGrid_dg.ColumnWidth = _columnWidth;
            return this;
        }
        /// <summary>
        /// Set all column width.
        /// </summary>
        /// <param name="_columnWidth">A DataGridLength param.</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setAllColumnWidth(DataGridLength _columnWidth) {
            myDataGrid_dg.ColumnWidth = _columnWidth;
            return this;
        }
        /// <summary>
        /// Set one column width.
        /// </summary>
        /// <param name="_header">A string param.</param>
        /// <param name="_width">An int param</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setOneColumnWidth(string _header, int _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.Width = _width;
                }
            }
            return this;
        }
        /// <summary>
        /// Set one column width.
        /// </summary>
        /// <param name="_header">A string param.</param>
        /// <param name="_width">A DataGridLength param.</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setOneColumnWidth(string _header, DataGridLength _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.Width = _width;
                }
            }
            return this;
        }
        /// <summary>
        /// Set one column max width.
        /// </summary>
        /// <param name="_header">A string param.</param>
        /// <param name="_width">An int param.</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setOneColumnMaxWidth(string _header, int _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.MaxWidth = _width;
                }
            }
            return this;
        }
        /// <summary>
        /// Set one column min width.
        /// </summary>
        /// <param name="_header">A string param.</param>
        /// <param name="_width">An int param.</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setOneColumnMinWidth(string _header, int _width) {
            foreach (DataGridColumn column in myDataGrid_dg.Columns) {
                if (_header.Equals(column.Header)) {
                    column.MinWidth = _width;
                }
            }
            return this;
        }
        /// <summary>
        /// Set all column max width.
        /// </summary>
        /// <param name="_columnMaxWidth">An int param.</param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid setMaxColumnWidth(int _columnMaxWidth) {
            myDataGrid_dg.ColumnWidth = _columnMaxWidth; 
            return this;
        }
    }
}