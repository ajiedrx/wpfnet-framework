using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows.Controls;

namespace MyFramework.ui_elements.date_picker
{
    internal class MyDatePicker : IMyDatePicker, IMyDatePickerInjector
    {
        private DatePicker myDatePicker_dat;
        private IMySolidColorBrush mySolidColorBrush;
        private IMyDateTime myDateTime;
        internal MyDatePicker(Object _deployedDatePicker) {
            myDatePicker_dat = (DatePicker)_deployedDatePicker;
        }

        #region properties
        public IMyDatePicker setTooltip(string _tooltip) {
            myDatePicker_dat.ToolTip = _tooltip;
            return this;
        }

        public IMyDatePicker setFontWeight(MyFontWeight myFontWeight) {
            myDatePicker_dat.FontWeight = myFontWeight.getFontWeight();
            return this;
        }

        public IMyDatePicker setFontStretch(MyFontStretch myFontStretch) {
            myDatePicker_dat.FontStretch = myFontStretch.getFontStretch();
            return this;
        }

        public IMyDatePicker setFontSize(int _fontSize) {
            myDatePicker_dat.FontSize = _fontSize;
            return this;
        }

        public IMyDatePicker setFontStyle(MyFontStyle myFontStyle) {
            myDatePicker_dat.FontStyle = myFontStyle.getFontStyle();
            return this;
        }

        public IMyDatePicker setTextVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myDatePicker_dat.VerticalContentAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyDatePicker setTextHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myDatePicker_dat.HorizontalContentAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyDatePicker setVerticalAlignment(MyVerticalAlignment myVerticalAlignment) {
            myDatePicker_dat.VerticalAlignment = myVerticalAlignment.getVerticalAlignment();
            return this;
        }

        public IMyDatePicker setHorizontalAlignment(MyHorizontalAlignment myHorizontalAlignment) {
            myDatePicker_dat.HorizontalAlignment = myHorizontalAlignment.getHorizontalAlignment();
            return this;
        }

        public IMyDatePicker setSelectedDate(int _year, int _month, int _day) {
            myDatePicker_dat.SelectedDate = myDateTime.getDateTime(_year,_month,_day);
            return this;
        }

        public IMyDatePicker setSelectedDate(string _date) {
            myDatePicker_dat.SelectedDate = myDateTime.getDateTime(_date);
            return this;
        }

        public string getShortDateString() {
            return myDatePicker_dat.SelectedDate.Value.ToShortDateString(); 
        }
        
        public string getLongDateString() {
            return myDatePicker_dat.SelectedDate.Value.ToLongDateString();
        }

        public IMyDatePicker setWidth(int _width) {
            myDatePicker_dat.Width = _width;
            return this;
        }
        public int getWidth() {
            return (int)myDatePicker_dat.Width;
        }

        public IMyDatePicker setMaxWidth(int _maxWidth) {
            myDatePicker_dat.MaxWidth = _maxWidth;
            return this;
        }
        public int getMaxWidth() {
            return (int)myDatePicker_dat.MaxWidth;
        }

        public IMyDatePicker setHeight(int _height) {
            myDatePicker_dat.Height = _height;
            return this;
        }
        public int getHeight() {
            return (int)myDatePicker_dat.Height;
        }

        public IMyDatePicker setMaxHeight(int _maxHeight) {
            myDatePicker_dat.MaxHeight = _maxHeight;
            return this;
        }
        public int getMaxHeight() {
            return (int)myDatePicker_dat.MaxHeight;
        }

        public IMyDatePicker setBackgroundColor(string _color) {
            myDatePicker_dat.Background = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        public IMyDatePicker setTextColor(string _color) {
            myDatePicker_dat.Foreground = mySolidColorBrush.setMyConverter(_color);
            return this;
        }

        #endregion

        #region event-handler

        public IMyDatePicker addSelectedDateChanged(IMyController _controller, string _methodName) {
            myDatePicker_dat.SelectedDateChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        public IMyDatePicker addDateValidationError(IMyController _controller, string _methodName) {
            myDatePicker_dat.DateValidationError += delegate (object sender, DatePickerDateValidationErrorEventArgs e) {
                _controller.callMethod(_methodName);
            };
            return this;
        }

        #endregion

        #region set-field

        public void setMyDateTime(IMyDateTime _myDateTime) {
            this.myDateTime = _myDateTime;
        }

        public void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush) {
            mySolidColorBrush = _mySolidColorBrush;
        }

        #endregion
    }
}
