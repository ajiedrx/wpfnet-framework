using MyFramework.basic;
using MyFramework.enums;
using MyFramework.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFramework.ui_elements.text_box
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
        IMyTextBox setInputValidation(Validator _validator);
        bool getInputValidation();
        IMyTextBox setBackgroundColor(string _color);
        IMyTextBox setTextColor(string _color);
        IMyTextBox addOnTextChanged(IMyController _controller, string _methodName);
        IMyTextBox addOnGotFocus(IMyController _controller, string _methodName);
        IMyTextBox addOnPreviewMouseDown(IMyController _controller, string _methodName);
    }
}
