using Velacro.UIElements.Basic;

namespace Velacro.UIElements.PasswordBox
{
    /// <summary>
    /// The PasswordBox element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// builderPasswordBox = new BuilderPasswordBox();
    /// testPasswordBox = builderPasswordBox
    ///         .activate(this, "testPasswordBox_psb")
    ///         .addOnTextChanged(this, "passwordBoxMethodTextChanged");
    /// </code>
    /// </example>
    public class BuilderPasswordBox
    {
        public BuilderPasswordBox() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyPasswordBox</returns>
        public IMyPasswordBox activate(IMyContainer _container, string _instanceName) {
            IMyPasswordBox myPasswordBox = new MyPasswordBox(_container.getComponentByName(_instanceName));
            return myPasswordBox;
        }
    }
}
