using MyFramework.basic;
using MyFramework.enums;
using System;
using System.Windows.Controls;

namespace MyFramework.ui_elements.date_picker
{
    internal class MyDatePicker : MyUIElements, IMyDatePicker, IMyDatePickerInjector
    {
        private DatePicker myDatePicker_dat;
        private IMyDateTime myDateTime;
        internal MyDatePicker(object _uiElement) : base((DatePicker)_uiElement) {
            myDatePicker_dat = (DatePicker)_uiElement;
        }

        #region properties
        /// <summary>
        /// Set the tooltip text.
        /// </summary>
        /// <param name="_tooltip">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>
        /// IMyDatePicker
        /// </returns>
        public IMyDatePicker setTooltip(string _tooltip) {
           base.setTooltip(_tooltip);
           return this;
        }
        /// <summary>
        /// Set the font weight.
        /// </summary>
        /// <param name="_myFontWeight"></param>
        /// <typeparam name="MyFontWeight">A MyFontWeight param.</typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setFontWeight(MyFontWeight _myFontWeight) {
            base.setFontWeight(_myFontWeight);
            return this;
        }
        /// <summary>
        /// Set the font stretch.
        /// </summary>
        /// <param name="_myFontStretch">A MyFontStretch param.</param>
        /// <typeparam name="MyFontStretch"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setFontStretch(MyFontStretch _myFontStretch) {
            base.setFontStretch(_myFontStretch);
            return this;
        }
        /// <summary>
        /// Set the font size.
        /// </summary>
        /// <param name="_fontSize">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setFontSize(int _fontSize) {
            base.setFontSize(_fontSize);
            return this;
        }
        /// <summary>
        /// Set the font style.
        /// </summary>
        /// <param name="_myFontStyle">A MyFontStyle param.</param>
        /// <typeparam name="MyFontStyle"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setFontStyle(MyFontStyle _myFontStyle) {
            base.setFontStyle(_myFontStyle);
            return this;
        }
        /// <summary>
        /// Set the text vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setTextVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setTextVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the text horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setTextHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setTextHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the vertical alignment.
        /// </summary>
        /// <param name="_myVerticalAlignment">A MyVerticalAlignment param.</param>
        /// <typeparam name="MyVerticalAlignment"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setVerticalAlignment(MyVerticalAlignment _myVerticalAlignment) {
            base.setVerticalAlignment(_myVerticalAlignment);
            return this;
        }
        /// <summary>
        /// Set the horizontal alignment.
        /// </summary>
        /// <param name="_myHorizontalAlignment">A MyHorizontalAlignment param.</param>
        /// <typeparam name="MyHorizontalAlignment"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setHorizontalAlignment(MyHorizontalAlignment _myHorizontalAlignment) {
            base.setHorizontalAlignment(_myHorizontalAlignment);
            return this;
        }
        /// <summary>
        /// Set the selected date.
        /// </summary>
        /// <param name="_year">An int param.</param>
        /// <param name="_month">An int param.</param>
        /// <param name="_day">An int param.</param>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setSelectedDate(int _year, int _month, int _day) {
            myDatePicker_dat.SelectedDate = myDateTime.getDateTime(_year,_month,_day);
            return this;
        }
        /// <summary>
        /// Set the selected date.
        /// </summary>
        /// <remarks>
        /// Insert any standard DateTime format in string.
        /// For more information about format please refer to Microsoft documentation.
        /// Below is some example of the formats by the official documentation.
        /// </remarks>
        /// <example>
        /// <code>
        /// (string dateAsString, string description)[]  dateInfo = {   ("08/18/2018 07:22:16", "String with a date and time component"),
        ///                                                             ("08/18/2018", "String with a date component only"),
        ///                                                             ("8/2018", "String with a month and year component only"),
        ///                                                             ("8/18", "String with a month and day component only"),
        ///                                                             ("07:22:16", "String with a time component only"),
        ///                                                             ("7 PM", "String with an hour and AM/PM designator only"),
        ///                                                             ("2018-08-18T07:22:16.0000000Z", "UTC string that conforms to ISO 8601"),
        ///                                                             ("2018-08-18T07:22:16.0000000-07:00", "Non-UTC string that conforms to ISO 8601"),
        ///                                                             ("Sat, 18 Aug 2018 07:22:16 GMT", "String that conforms to RFC 1123"),
        ///                                                             ("08/18/2018 07:22:16 -5:00", "String with date, time, and time zone information" ) };
        /// </code>
        /// </example>
        /// <param name="_date">A string param.</param>
        /// <returns></returns>
        public IMyDatePicker setSelectedDate(string _date) {
            myDatePicker_dat.SelectedDate = myDateTime.getDateTime(_date);
            return this;
        }
        /// <summary>
        /// Get the short date of the selected date.
        /// </summary>
        /// <returns>string</returns>
        public string getShortDateString() {
            return myDatePicker_dat.SelectedDate.Value.ToShortDateString(); 
        }
        /// <summary>
        /// Get the long date of the selected date.
        /// </summary>
        /// <returns>string</returns>
        public string getLongDateString() {
            return myDatePicker_dat.SelectedDate.Value.ToLongDateString();
        }
        /// <summary>
        /// Set the width of the DatePicker.
        /// </summary>
        /// <param name="_width">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setWidth(int _width) {
            base.setWidth(_width);
            return this;
        }
        /// <summary>
        /// Get the width of the DatePicker.
        /// </summary>
        /// <returns>int</returns>
        public int getWidth() {
            return base.getWidth();
        }
        /// <summary>
        /// Set the DatePicker max width.
        /// </summary>
        /// <param name="_maxWidth">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setMaxWidth(int _maxWidth) {
            base.setMaxWidth(_maxWidth);
            return this;
        }
        /// <summary>
        /// Get the max width of the DatePicker.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxWidth() {
            return base.getMaxWidth();
        }
        /// <summary>
        /// Set the DatePicker height.
        /// </summary>
        /// <param name="_height">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setHeight(int _height) {
            base.setHeight(_height);
            return this;
        }
        /// <summary>
        /// Get the height of the DatePicker.
        /// </summary>
        /// <returns>int</returns>
        public int getHeight() {
            return base.getHeight();
        }
        /// <summary>
        /// Set the DatePicker max height.
        /// </summary>
        /// <param name="_maxHeight">An int param.</param>
        /// <typeparam name="int"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setMaxHeight(int _maxHeight) {
            base.setMaxHeight(_maxHeight);
            return this;
        }
        /// <summary>
        /// Get the DatePicker max height.
        /// </summary>
        /// <returns>int</returns>
        public int getMaxHeight() {
            return base.getMaxHeight();
        }
        /// <summary>
        /// Set the DatePicker background color.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setBackgroundColor(string _hexColor) {
            base.setBackgroundColor(_hexColor);
            return this;
        }
        /// <summary>
        /// Set the DatePicker text color.
        /// </summary>
        /// <param name="_color">A string hex param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setTextColor(string _hexColor) {
            base.setTextColor(_hexColor);
            return this;
        }

        /// <summary>
        /// Set the DatePicker background image.
        /// </summary>
        /// <param name="_color">A string param.</param>
        /// <typeparam name="string"></typeparam>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker setBackgroundImage(string _path) {
            base.setBackgroundImage(_path);
            return this;
        }

        #endregion

        #region event-handler
        /// <summary>
        /// Add selectedDateChanged listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker addSelectedDateChanged(IMyController _controller, string _methodName) {
            myDatePicker_dat.SelectedDateChanged += delegate (object sender, SelectionChangedEventArgs e) {
                _controller.callMethod(_methodName, myDatePicker_dat.SelectedDate);
            };
            return this;
        }
        /// <summary>
        /// Add dateValidationError listener.
        /// </summary>
        /// <param name="_controller"></param>
        /// <param name="_methodName"></param>
        /// <returns>IMyDatePicker</returns>
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

        #endregion
    }
}
