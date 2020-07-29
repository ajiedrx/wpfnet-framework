

using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.list_box
{
    public interface IMyListBox
    {
        IMyListBox setTooltip(string _tooltip);
        IMyListBox setFontWeight(MyFontWeight myFontWeight);
        IMyListBox setFontStretch(MyFontStretch myFontStretch);
        IMyListBox setFontSize(int _fontSize);
        IMyListBox setFontStyle(MyFontStyle myFontStyle);
        IMyListBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyListBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

        IMyListBox addItem(string _item);
        string getSelectedItem();
        MyList<string> getSelectedItems();
        int getSelectedItemIndex();
        int getNumberOfItems();
        IMyListBox setItemList(MyList<string> _listOfItem);
        IMyListBox setHeight(int _height);
        int getHeight();
        IMyListBox setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyListBox setWidth(int _width);
        int getWidth();
        IMyListBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyListBox setBackgroundColor(string _color);
        IMyListBox setTextColor(string _color);
        IMyListBox addOnSelectionChanged(IMyController _controller, string _methodName);
        IMyListBox addOnSelectionChanged(IMyView _view, string _methodName);
    }
}