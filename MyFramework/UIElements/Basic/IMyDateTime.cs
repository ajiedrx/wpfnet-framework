using System;

namespace Velacro.UIElements.Basic {
    public interface IMyDateTime
    {
        DateTime getDateTime();
        DateTime getDateTime(string _date);
        DateTime getDateTime(int _year, int _month, int _day);
        DateTime getCurrentDate();
        DateTime getCurrentDateAndTime();
    }
}