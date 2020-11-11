using MyFramework.basic;
using System;

namespace MyFramework.ui_elements.combo_box {
    /// <summary>
    /// The ComboBox element builder class.
    /// </summary>
    /// <remarks>Below is an usage example</remarks>
    /// <example>
    /// <code>
    /// IMyComboBox comboBox;
    /// BuilderComboBox builderComboBox = new BuilderComboBox();
    /// comboBox = builderComboBox
    /// .activate(this, "comboBox_cbx")
    /// .setText("Test")
    /// .addOnSelectionChanged(this, "onCheckedMethodName");
    /// </code>
    /// </example>
    public class BuilderComboBox
    {
        public BuilderComboBox() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyComboBox</returns>
        public IMyComboBox activate(IMyContainer _container, String _instanceName) {
            IMyComboBox comboBox = new MyComboBox(_container.getComponentByName(_instanceName));
            return comboBox;
        }
    }
}
