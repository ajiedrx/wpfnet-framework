using System;
using Velacro.Basic;
using Velacro.Enums;

namespace Velacro.UIElements.TextBox
{
    public interface IMyTextBox
    {
        IMyTextBox setTooltip(string _tooltip);
        IMyTextBox setFontWeight(MyFontWeight myFontWeight);
        IMyTextBox setFontStretch(MyFontStretch myFontStretch);
        IMyTextBox setFontSize(int _fontSize);
        IMyTextBox setFontStyle(MyFontStyle myFontStyle);
        IMyTextBox setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyTextBox setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyTextBox setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyTextBox setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

        IMyTextBox setText(String _text);
        string getText();
        IMyTextBox setWidth(int _width);
        int getWidth();
        IMyTextBox setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyTextBox setHeight(int _height);
        int getHeight();
        IMyTextBox setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyTextBox setMaxLength(int _maxLength);
        IMyTextBox setInputValidation(Validator.Validator _validator);
        bool getInputValidation();
        IMyTextBox setBackgroundColor(string _hexColor);
        IMyTextBox setTextColor(string _hexColor);
        IMyTextBox setBackgroundImage(string _path);
        IMyTextBox addOnTextChanged(IMyController _controller, string _methodName);
        IMyTextBox addOnGotFocus(IMyController _controller, string _methodName);
        IMyTextBox addOnPreviewMouseDown(IMyController _controller, string _methodName);
    }
}
