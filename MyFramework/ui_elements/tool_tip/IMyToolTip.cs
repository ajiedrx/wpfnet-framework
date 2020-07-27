using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.tool_tip {
    public interface IMyToolTip
    {
        IMyToolTip setFontWeight(MyFontWeight myFontWeight);
        IMyToolTip setFontStretch(MyFontStretch myFontStretch);
        IMyToolTip setFontSize(int _fontSize);
        IMyToolTip setFontStyle(MyFontStyle myFontStyle);
        IMyToolTip setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyToolTip setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyToolTip setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyToolTip setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyToolTip setText(string _text);
        IMyToolTip setTextColor(string _color);
        IMyToolTip setBackgroundColor(string _color);
        IMyToolTip setWidth(int _width);
        int getWidth();
        IMyToolTip setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyToolTip setHeight(int _height);
        int getHeight();
        IMyToolTip setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyToolTip setDropShadow(bool _value);
        bool hasDropShadow();
        IMyToolTip addOnToolTipOpening(IMyController _controller, string _methodName);
        IMyToolTip addOnClosed(IMyController _controller, string _methodName);
    }
}