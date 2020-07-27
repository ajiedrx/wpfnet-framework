using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.check_box {
    public interface IMyCheckBox
    {
        bool isChecked();
        IMyCheckBox setTooltip(string _tooltip);
        IMyCheckBox setFontWeight(MyFontWeight myFontWeight);
        IMyCheckBox setFontStretch(MyFontStretch myFontStretch);

        IMyCheckBox setFontSize(int _fontSize);
        IMyCheckBox setFontStyle(MyFontStyle myFontStyle);
        IMyCheckBox setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyCheckBox setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyCheckBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyCheckBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

        IMyCheckBox setText(string _text);
        IMyCheckBox setWidth(int _width);
        int getWidth();
        IMyCheckBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyCheckBox setHeight(int _height);
        int getHeight();
        IMyCheckBox setMaxHeight(int _maxHeight);
        int getMaxHeight();

        IMyCheckBox setTextColor(string _color);
        IMyCheckBox setBackgroundColor(string _color);
        IMyCheckBox addOnClick(IMyController _controller, string _methodName);
        IMyCheckBox addOnChecked(IMyController _controller, string _methodName);
    }
}