using MyFramework.basic;

namespace MyFramework.ui_elements.radio_button
{
    public class BuilderRadioButton
    {
        private IMySolidColorBrush mySolidColorBrush = new MySolidColorBrush();
        public BuilderRadioButton() { }
        public IMyRadioButton activate(IMyContainer _container, string _instanceName) {
            IMyRadioButton myRadioButton = new MyRadioButton(_container.getComponentByName(_instanceName));

            IMyRadioButtonInjector myRadioButtonInjector = (IMyRadioButtonInjector)myRadioButton;
            myRadioButtonInjector.setMySolidColorBrush(mySolidColorBrush);

            return myRadioButton;
        }

    }
}
