using MyFramework.basic;
using MyFramework.enums;
using System;

namespace MyFramework.ui_elements.password_box
{
    public interface IMyPasswordBox
    {
        IMyPasswordBox setTooltip(string _tooltip);
        IMyPasswordBox setFontWeight(MyFontWeight myFontWeight);
        IMyPasswordBox setFontStretch(MyFontStretch myFontStretch);
        IMyPasswordBox setFontSize(int _fontSize);
        IMyPasswordBox setFontStyle(MyFontStyle myFontStyle);
        IMyPasswordBox setPasswordVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyPasswordBox setPasswordHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyPasswordBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyPasswordBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

        IMyPasswordBox setPassword(string _Password);
        String getPassword();
        IMyPasswordBox setChar(char _char);
        IMyPasswordBox setMaxLength(int _maxLength);
        IMyPasswordBox setWidth(int _width);
        int getWidth();
        IMyPasswordBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyPasswordBox setHeight(int _height);
        int getHeight();
        IMyPasswordBox setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyPasswordBox setBackgroundColor(string _color);
        IMyPasswordBox setTextColor(string _color);
        IMyPasswordBox addOnTextChanged(IMyController _controller, string _methodName);
        IMyPasswordBox addOnGotFocus(IMyController _controller, string _methodName);
        IMyPasswordBox addOnPreviewMouseDown(IMyController _controller, string _methodName);

    }
}