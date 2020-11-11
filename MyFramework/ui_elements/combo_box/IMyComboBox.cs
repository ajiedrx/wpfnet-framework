using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFramework.datastructures;

namespace MyFramework.ui_elements.combo_box {
    public interface IMyComboBox
    {
        IMyComboBox setTooltip(string _tooltip);
        IMyComboBox setFontWeight(MyFontWeight _myFontWeight);
        IMyComboBox setFontStretch(MyFontStretch _myFontStretch);
        IMyComboBox setFontSize(int _fontSize);
        IMyComboBox setFontStyle(MyFontStyle _myFontStyle);
        IMyComboBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyComboBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);
        IMyComboBox setSelectedItem(string _itemName);
        string getSelectedString();
        object getSelectedItem();
        IMyComboBox setSelectedItemIndex(int _itemIndex);
        int getSelectedItemIndex();
        bool isDropDownOpen();
        IMyComboBox addItem<T>(T _item);
        IMyComboBox addItems<T>(MyList<T> _item);

        IMyComboBox setHeight(int _height);
        int getHeight();
        IMyComboBox setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyComboBox setWidth(int _width);
        int getWidth();
        IMyComboBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyComboBox setBackgroundColor(string _hexColor);
        IMyComboBox setTextColor(string _hexColor);
        IMyComboBox addOnDropDownOpened(IMyController _controller, string _methodName);
        IMyComboBox addOnDropDownClosed(IMyController _controller, string _methodName);
        IMyComboBox addOnSelectionChanged(IMyController _controller, string _methodName);
        IMyComboBox addOnDropDownOpened(IMyView IMyView, string _methodName);
        IMyComboBox addOnDropDownClosed(IMyView IMyView, string _methodName);
        IMyComboBox addOnSelectionChanged(IMyView IMyView, string _methodName);

    }
}
