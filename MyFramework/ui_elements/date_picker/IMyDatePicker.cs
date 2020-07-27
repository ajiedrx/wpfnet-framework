using MyFramework.basic;
using MyFramework.enums;
using System;

namespace MyFramework.ui_elements.date_picker
{
    public interface IMyDatePicker
    {
        IMyDatePicker setTooltip(string _tooltip);
        IMyDatePicker setFontWeight(MyFontWeight myFontWeight);
        IMyDatePicker setFontStretch(MyFontStretch myFontStretch);
        IMyDatePicker setFontSize(int _fontSize);
        IMyDatePicker setFontStyle(MyFontStyle myFontStyle);
        IMyDatePicker setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyDatePicker setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyDatePicker setVerticalAlignment(MyVerticalAlignment myVerticalAlignment);
        IMyDatePicker setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment);
        IMyDatePicker setSelectedDate(int _year, int _month, int _day);
        IMyDatePicker setSelectedDate(string _date);
        string getShortDateString();
        string getLongDateString();
        IMyDatePicker setWidth(int _width);
        int getWidth();
        IMyDatePicker setMaxWidth(int _maxWidth);
        int getMaxWidth();
        IMyDatePicker setHeight(int _height);
        int getHeight();
        IMyDatePicker setMaxHeight(int _maxHeight);
        int getMaxHeight();
        IMyDatePicker setBackgroundColor(string _color);
        IMyDatePicker setTextColor(string _color);

        IMyDatePicker addSelectedDateChanged(IMyController _controller, string _methodName);

        IMyDatePicker addDateValidationError(IMyController _controller, string _methodName);

    }
}