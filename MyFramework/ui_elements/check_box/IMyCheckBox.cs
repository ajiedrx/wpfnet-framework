using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.check_box {
    public interface IMyCheckBox
    {
        bool isChecked();
        IMyCheckBox setTooltip(string _tooltip);
        IMyCheckBox setFontWeight(MyFontWeight _myFontWeight);
        IMyCheckBox setFontStretch(MyFontStretch _myFontStretch);

        IMyCheckBox setFontSize(int _fontSize);
        IMyCheckBox setFontStyle(MyFontStyle _myFontStyle);
        IMyCheckBox setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyCheckBox setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);
        IMyCheckBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyCheckBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);

        IMyCheckBox setText(string _text);
        IMyCheckBox setWidth(int _width);
        int getWidth();
        IMyCheckBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyCheckBox setHeight(int _height);
        int getHeight();
        IMyCheckBox setMaxHeight(int _maxHeight);
        int getMaxHeight();

        IMyCheckBox setTextColor(string _hexColor);
        IMyCheckBox setBackgroundColor(string _hexColor);
        IMyCheckBox setBackgroundImage(string _path);
        IMyCheckBox addOnClick(IMyController _controller, string _methodName);
        IMyCheckBox addOnChecked(IMyController _controller, string _methodName);

        IMyCheckBox addOnUnchecked(IMyController _controller, string _methodName);
        IMyCheckBox addOnClick(IMyView _view, string _methodName);
        IMyCheckBox addOnChecked(IMyView _view, string _methodName);
        IMyCheckBox addOnUnchecked(IMyView _view, string _methodName);
    }
}