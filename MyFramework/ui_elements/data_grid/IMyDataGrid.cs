using MyFramework.basic;
using System.Windows.Controls;

namespace MyFramework.ui_elements.data_grid {
    public interface IMyDataGrid
    {
        IMyDataGrid addItemSource<T>(MyList<T> _listItem);
        IMyDataGrid addItem<T>(T _item);
        IMyDataGrid setColumnHeader(string _columnHeader, string _propertyName);
        IMyDataGrid setColumnDataBinding<T>(MyList<string> _columnHeader, MyList<string> _propertyName, MyList<T> _data);
        IMyDataGrid setHeight(int _height);
        int getHeight();
        IMyDataGrid setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyDataGrid setWidth(int _width);
        int getWidth();
        IMyDataGrid setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyDataGrid setAllColumnWidth(int _columnWidth);
        IMyDataGrid setAllColumnWidth(DataGridLength _columnWidth);
        IMyDataGrid setOneColumnWidth(string _header, int _width);
        IMyDataGrid setOneColumnWidth(string _header, DataGridLength _width);
        IMyDataGrid setOneColumnMaxWidth(string _header, int _width);
        IMyDataGrid setOneColumnMinWidth(string _header, int _width);
        IMyDataGrid setMaxColumnWidth(int _columnMaxWidth);
    }
}