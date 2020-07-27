using System;
using System.Windows.Controls.Primitives;

namespace MyFramework.ui_elements.toggle_button {
    internal class MyToggleButton : IMyToggleButton
    {
        private ToggleButton myToggleButton;
        internal MyToggleButton(Object _deployedToggleButton) {
            myToggleButton = (ToggleButton)_deployedToggleButton;
        }
        #region properties
        #endregion

        #region event-handler
        #endregion

        #region set-field
        #endregion
    }
}
