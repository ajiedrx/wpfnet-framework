using Velacro.UIElements.Basic;

namespace Velacro.UIElements.RadioButton
{
    /// <summary>
    /// The RadioButton element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// builderRadioButton = new BuilderRadioButton();
    /// testRadioButton = builderRadioButton
    ///         .activate(this, "testRadioButton_psb")
    ///         .setGroupName("radioGroupA");
    /// </code>
    /// </example>
    public class BuilderRadioButton
    {
        public BuilderRadioButton() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyRadioButton</returns>
        public IMyRadioButton activate(IMyContainer _container, string _instanceName) {
            IMyRadioButton myRadioButton = new MyRadioButton(_container.getComponentByName(_instanceName));
            return myRadioButton;
        }

    }
}
