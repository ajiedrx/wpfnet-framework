using System;
using Velacro.UIElements.Basic;

namespace Velacro.UIElements.TextBox
{
    /// <summary>
    /// The TextBox element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// builderTextBox = new BuilderTextBox();
    /// testTextBox = builderTextBox
    ///         .activate(this, "testTextBox_tb");
    /// </code>
    /// </example>
    public class BuilderTextBox
    {
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyTextBox</returns>
        public BuilderTextBox() { }
        public IMyTextBox activate(IMyContainer _container, String _instanceName) {
            IMyTextBox textBox = new MyTextBox(_container.getComponentByName(_instanceName));
            return textBox;
        }
    }
}
