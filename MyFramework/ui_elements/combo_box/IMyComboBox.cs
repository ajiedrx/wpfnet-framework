using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.combo_box {
    public interface IMyComboBox
    {
        IMyComboBox setTooltip(string _tooltip);
        IMyComboBox setFontWeight(MyFontWeight myFontWeight);
        IMyComboBox setFontStretch(MyFontStretch myFontStretch);
        IMyComboBox setFontSize(int _fontSize);
        IMyComboBox setFontStyle(MyFontStyle myFontStyle);
        IMyComboBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyComboBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyComboBox setSelectedItem(string _itemName);
        string getSelectedItem();
        IMyComboBox setSelectedItemIndex(int _itemIndex);
        int getSelectedItemIndex();
        bool isDropDownOpen();
        IMyComboBox addItem(string _item);
        IMyComboBox setItemList(MyList<string> _listOfItem);

        IMyComboBox setHeight(int _height);
        int getHeight();
        IMyComboBox setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyComboBox setWidth(int _width);
        int getWidth();
        IMyComboBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyComboBox setBackgroundColor(string _color);
        IMyComboBox setTextColor(string _color);
        IMyComboBox addOnDropDownOpened(IMyController _controller, string _methodName);
        IMyComboBox addOnDropDownClosed(IMyController _controller, string _methodName);
        IMyComboBox addOnSelectionChanged(IMyController _controller, string _methodName);

    }
}
