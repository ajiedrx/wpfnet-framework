using MyFramework.basic;
using MyFramework.validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.ui_elements.text_box
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
