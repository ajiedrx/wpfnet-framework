using Velacro.UIElements.Basic;

namespace Velacro.UIElements.ListBox
{
    /// <summary>
    /// The ListBox element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// IMyListBox listBox;
    /// MyList<string> items = new MyList<string>(){ 
    ///     "Item1", "Item2", "Item3", "Item4"
    /// };
    /// BuilderListBox builderListBox = new BuilderListBox();
    /// listBox = builderListBox;
    /// .activate(this, "listBox_lb")
    /// .addItems(items);
    /// </code>
    /// </example>
    public class BuilderListBox
    {
        public BuilderListBox() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyListBox</returns>
        public IMyListBox activate(IMyContainer _container, string _instanceName) {
            IMyListBox myListBox = new MyListBox(_container.getComponentByName(_instanceName));
            return myListBox;
        }
    }
}
