using MyFramework.basic;

namespace MyFramework.ui_elements.check_box
{
    /// <summary>
    /// The CheckBox element builder class.
    /// </summary>
    /// <remarks>Below is an usage example</remarks>
    /// <example>
    /// <code>
    /// IMyCheckBox checkBox;
    /// BuilderCheckBox builderCheckBox = new BuilderCheckBox();
    /// checkBox = builderCheckBox;
    /// .activate(this, "checkBox_cb")
    /// .setText("Test")
    /// .addOnChecked(this, "onCheckedMethodName");
    /// </code>
    /// </example>
    public class BuilderCheckBox
    {
        public BuilderCheckBox() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyCheckBox</returns>
        public IMyCheckBox activate(IMyContainer _container, string _instanceName) {
            IMyCheckBox myCheckBox = new MyCheckBox(_container.getComponentByName(_instanceName));
            return myCheckBox;
        }
    }
}
