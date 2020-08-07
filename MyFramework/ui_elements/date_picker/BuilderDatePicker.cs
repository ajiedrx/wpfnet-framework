using MyFramework.basic;
using System;

namespace MyFramework.ui_elements.date_picker
{
    /// <summary>
    /// The DatePicker element builder class.
    /// </summary>
    /// <remarks>Below is an usage example</remarks>
    /// <example>
    /// <code>
    /// IMyDatePicker datePicker;
    /// BuilderDatePicker builderDatePicker = new BuilderDatePicker();
    /// datePicker = builderDatePicker;
    /// .activate(this, "datePicker_dp");
    /// </code>
    /// </example>
    public class BuilderDatePicker
    {
        private IMyDateTime myDateTime = new MyDateTime();
        public BuilderDatePicker() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyDatePicker</returns>
        public IMyDatePicker activate(IMyContainer _container, String _instanceName)
        {
            IMyDatePicker datePicker = new MyDatePicker(_container.getComponentByName(_instanceName));

            IMyDatePickerInjector datePickerInjector = (IMyDatePickerInjector)datePicker;
            datePickerInjector.setMyDateTime(myDateTime);

            return datePicker;
        }
    }
}
