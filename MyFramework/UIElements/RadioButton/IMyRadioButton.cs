using Velacro.Basic;
using Velacro.Enums;

namespace Velacro.UIElements.RadioButton
{
    public interface IMyRadioButton
    {
        IMyRadioButton setTooltip(string _tooltip);
        IMyRadioButton setFontWeight(MyFontWeight _myFontWeight);
        IMyRadioButton setFontStretch(MyFontStretch _myFontStretch);
        IMyRadioButton setFontSize(int _fontSize);
        IMyRadioButton setFontStyle(MyFontStyle myFontStyle);
        IMyRadioButton setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyRadioButton setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);
        IMyRadioButton setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment);
        IMyRadioButton setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment);

        IMyRadioButton setValue(bool _value);
        bool getValue();
        IMyRadioButton setText(string _text);
        IMyRadioButton setWidth(int _width);
        int getWidth();
        IMyRadioButton setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyRadioButton setHeight(int _height);
        int getHeight();
        IMyRadioButton setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyRadioButton setBackgroundColor(string _hexColor);
        IMyRadioButton setTextColor(string _hexColor);
        IMyRadioButton setBackgroundImage(string _path);
        IMyRadioButton setGroupName(string _name);
        IMyRadioButton addOnClick(IMyController _controller, string _methodName);
        IMyRadioButton addOnChecked(IMyController _controller, string _methodName);

    }
}