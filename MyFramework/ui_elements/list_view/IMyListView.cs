using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.list_view
{
    public interface IMyListView
    {
        IMyListView addItem<T>(T _item);
        IMyListView addItems<T>(MyList<T> _items);
        IMyListView addGridViewColumns(MyList<string> _headers, MyList<string> _propertyNames);
       
        object getSelectedItem();
        int getNumberOfItems();
        IMyListView setHeight(int _height);
        IMyListView setWidth(int _width);
        IMyListView setBackgroundColor(string _hexColor);
        IMyListView setBackgroundImage(string _path);
        IMyListView setTextColor(string _hexColor);
        IMyListView addOnSelectionChanged(IMyView _view, string _methodName);
        IMyListView addOnSelectionChanged(IMyController _controller, string _methodName);
    }
}
