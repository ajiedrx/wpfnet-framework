using MyFramework.basic;

namespace MyFramework.ui_elements.data_grid
{
    /// <summary>
    /// The DataGrid element builder class.
    /// </summary>
    /// <remarks>Below is an usage example</remarks>
    /// <example>
    /// <code>
    /// IMyDataGrid dataGrid;
    /// BuilderDataGrid builderDataGrid = new BuilderDataGrid();
    /// dataGrid = builderDataGrid;
    /// .activate(this, "dataGrid_dg")
    /// .setText("Test")
    /// .setColumnDataBinding(columnHeader, propertyNames, datas);
    /// </code>
    /// </example>
    public class BuilderDataGrid
    {
        public BuilderDataGrid() { }
        /// <summary>
        /// Method for getting the UI Element instance.
        /// </summary>
        /// <param name="_container"></param>
        /// <param name="_instanceName"></param>
        /// <returns>IMyDataGrid</returns>
        public IMyDataGrid activate(IMyContainer _container, string _instanceName)
        {
            IMyDataGrid myDataGrid = new MyDataGrid(_container.getComponentByName(_instanceName));
            return myDataGrid;
        }

    }
}
