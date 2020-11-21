using System;
using Velacro.Basic;
using Velacro.Enums;

namespace Velacro.UIElements.PasswordBox
{
    public interface IMyPasswordBox
    {
        IMyPasswordBox setTooltip(string _tooltip);
        IMyPasswordBox setFontWeight(MyFontWeight _myFontWeight);
        IMyPasswordBox setFontStretch(MyFontStretch _myFontStretch);
        IMyPasswordBox setFontSize(int _fontSize);
        IMyPasswordBox setFontStyle(MyFontStyle myFontStyle);
        IMyPasswordBox setPasswordVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyPasswordBox setPasswordHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);
        IMyPasswordBox setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyPasswordBox setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);

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
        IMyPasswordBox setBackgroundColor(string _hexColor);
        IMyPasswordBox setTextColor(string _hexColor);
        IMyPasswordBox setBackgroundImage(string _path);
        IMyPasswordBox addOnTextChanged(IMyController _controller, string _methodName);
        IMyPasswordBox addOnGotFocus(IMyController _controller, string _methodName);
        IMyPasswordBox addOnPreviewMouseDown(IMyController _controller, string _methodName);

        IMyPasswordBox addOnTextChanged(IMyView _view, string _methodName);
        IMyPasswordBox addOnGotFocus(IMyView _view, string _methodName);
        IMyPasswordBox addOnPreviewMouseDown(IMyView _view, string _methodName);
    }
}