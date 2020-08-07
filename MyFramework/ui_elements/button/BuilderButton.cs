using MyFramework.basic;

namespace MyFramework.ui_elements.button
{
    /// <summary>
    /// The button element builder class.
    /// </summary>
    /// <remarks>Below is an usage example</remarks>
    /// <example>
    /// <code>
    /// IMyButton button;
    /// BuilderButton builderButton = new BuilderButton();
    /// button = builderButton
    ///          .activate(this, "button_btn")
    ///          .setText("Test");
    /// </code>
    /// </example>
    public class BuilderButton
    {
        public BuilderButton() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyButton</returns>
        public IMyButton activate(IMyContainer _container, string _instanceName)
        {
            IMyButton button = new MyButton(_container.getComponentByName(_instanceName));
            return button;
        }
    }
}
