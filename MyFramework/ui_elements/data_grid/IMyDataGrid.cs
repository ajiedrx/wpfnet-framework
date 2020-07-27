using MyFramework.basic;

namespace MyFramework.ui_elements.data_grid {
    public interface IMyDataGrid
    {
        IMyDataGrid addItemSource<T>(MyList<T> _listItem);
        IMyDataGrid addItem<T>(T _item);
        IMyDataGrid setColumnHeader(string _columnHeader, string _propertyName);
        IMyDataGrid setColumnHeader(MyList<string> _columnHeader, MyList<string> _propertyName);
        IMyDataGrid setHeight(int _height);
        int getHeight();
        IMyDataGrid setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyDataGrid setWidth(int _width);
        int getWidth();
        IMyDataGrid setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyDataGrid setColumnWidth(int _columnWidth);
        IMyDataGrid setMaxColumnWidth(int _columnMaxWidth);
    }
}