

using MyFramework.basic;
using MyFramework.datastructures;
using MyFramework.enums;

namespace MyFramework.ui_elements.list_box
{
    public interface IMyListBox
    {
        IMyListBox setTooltip(string _tooltip);
        IMyListBox setFontWeight(MyFontWeight _myFontWeight);
        IMyListBox setFontStretch(MyFontStretch _myFontStretch);
        IMyListBox setFontSize(int _fontSize);
        IMyListBox setFontStyle(MyFontStyle _myFontStyle);
        IMyListBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyListBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);

        IMyListBox addItem(string _item);
        string getSelectedItem();
        MyList<string> getSelectedItems();
        int getSelectedItemIndex();
        int getNumberOfItems();
        IMyListBox setItemsSource<T>(MyList<T> _listOfItem);
        IMyListBox setHeight(int _height);
        int getHeight();
        IMyListBox setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyListBox setWidth(int _width);
        int getWidth();
        IMyListBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyListBox setBackgroundColor(string _hexColor);
        IMyListBox setBackgroundImage(string _path);
        IMyListBox setTextColor(string _hexColor);
        IMyListBox addOnSelectionChanged(IMyController _controller, string _methodName);
        IMyListBox addOnSelectionChanged(IMyView _view, string _methodName);
    }
}