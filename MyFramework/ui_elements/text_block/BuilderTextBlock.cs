using MyFramework.basic;

namespace MyFramework.ui_elements.text_block
{
    /// <summary>
    /// The TextBlock element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// builderTextBlock = new BuilderTextBlock();
    /// testTextBlock = builderTextBlock
    ///         .activate(this, "testTextBlock_tbl");
    /// </code>
    /// </example>
    public class BuilderTextBlock
    {
        public BuilderTextBlock() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyTextBlock</returns>
        public IMyTextBlock activate(IMyContainer _container, string _instanceName) {
            IMyTextBlock myTextBlock = new MyTextBlock(_container.getComponentByName(_instanceName));
            return myTextBlock;
        }
    }
}
