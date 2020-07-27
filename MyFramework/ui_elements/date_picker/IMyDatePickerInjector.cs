using MyFramework.basic;

namespace MyFramework.ui_elements.date_picker
{
    internal interface IMyDatePickerInjector
    {
        void setMyDateTime(IMyDateTime _myDateTime);
        void setMySolidColorBrush(IMySolidColorBrush _mySolidColorBrush);
    }
}