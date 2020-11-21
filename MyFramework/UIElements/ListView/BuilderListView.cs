using Velacro.UIElements.Basic;

namespace Velacro.UIElements.ListView {
    /// <summary>
    /// The ListView element builder class.
    /// </summary>
    /// <remarks>
    /// For more detailed information please refer to the main class of the element.
    /// Below is an usage example
    /// </remarks>
    /// <example>
    /// <code>
    /// MyList<string> header = new MyList<string>() { "Key", "Name" };
    /// MyList<string> properties = new MyList<string>() { "key", "name" };
    /// MyList<TestModel> datas = new MyList<TestModel> {
    ///         new TestModel() {
    ///             key = 1, name = "AA" },
    ///         new TestModel() {
    ///             key = 2, name = "BB" }};
    /// 
    /// builderListView = new BuilderListView();
    /// testListView = builderListView
    ///         .activate(this, "testListView_lsv")
    ///         .addGridViewColumns(header,properties)
    ///         .addItems(datas)
    ///         .addOnSelectionChanged(this, "testListViewMethod");
    /// </code>
    /// </example>
    public class BuilderListView
    {
        public BuilderListView() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyListView</returns>
        public IMyListView activate(IMyContainer _container, string _instanceName) {
            IMyListView myListView = new MyListView(_container.getComponentByName(_instanceName));
            return myListView;
        }
    }
}
