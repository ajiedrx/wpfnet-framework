using MyFramework.basic;
using System;

namespace MyFramework.ui_elements.date_picker
{
    public class BuilderDatePicker
    {
        private IMyDateTime myDateTime = new MyDateTime();
        public BuilderDatePicker() { }

        public IMyDatePicker activate(IMyContainer _container, String _instanceName)
        {
            IMyDatePicker datePicker = new MyDatePicker(_container.getComponentByName(_instanceName));

            IMyDatePickerInjector datePickerInjector = (IMyDatePickerInjector)datePicker;
            datePickerInjector.setMyDateTime(myDateTime);

            return datePicker;
        }
    }
}
