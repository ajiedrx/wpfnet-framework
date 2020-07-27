using MyFramework.basic;
using MyFramework.enums;

namespace MyFramework.ui_elements.radio_button
{
    public interface IMyRadioButton
    {
        IMyRadioButton setTooltip(string _tooltip);
        IMyRadioButton setFontWeight(MyFontWeight myFontWeight);
        IMyRadioButton setFontStretch(MyFontStretch myFontStretch);
        IMyRadioButton setFontSize(int _fontSize);
        IMyRadioButton setFontStyle(MyFontStyle myFontStyle);
        IMyRadioButton setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyRadioButton setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyRadioButton setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyRadioButton setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);

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
        IMyRadioButton setBackgroundColor(string _color);
        IMyRadioButton setTextColor(string _color);

        IMyRadioButton addOnClick(IMyController _controller, string _methodName);
        IMyRadioButton addOnChecked(IMyController _controller, string _methodName);
    }
}