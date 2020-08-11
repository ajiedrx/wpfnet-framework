using MyFramework.basic;
using MyFramework.chart.barchart;
using MyFramework.chart.linechart;
using MyFramework.ui_elements.button;
using MyFramework.ui_elements.data_grid;
using MyFramework.ui_elements.list_box;
using MyFramework.ui_elements.list_view;
using MyFramework.ui_elements.password_box;
using MyFramework.ui_elements.progress_bar;
using System;

namespace MyFramework {
    public partial class MainWindow : MyWindow {
        BuilderButton builderButton;
        BuilderDataGrid builderDataGrid;
        BuilderListBox builderListBox;
        BuilderListView builderListView;
        BuilderPasswordBox builderPasswordBox;
        BuilderProgressBar builderProgressBar;
        BuilderLineChart builderLineChart;

        IMyButton testButton;
        IMyDataGrid testDataGrid;
        IMyListBox testListBox;
        IMyListView testListView;
        IMyPasswordBox testPasswordBox;
        IMyProgressBar testProgressBar;
        IMyLineChart lineChart;

        public MainWindow() {
            InitializeComponent();
            builderButton = new BuilderButton();
            testButton = builderButton
                .activate(this, "testButton_btn")
                .setTooltip("Ini button Test");

            MyList<string> header = new MyList<string>() { "Key", "Name" };
            MyList<string> properties = new MyList<string>() { "key", "name" };
            MyList<TestModel> datas = new MyList<TestModel> { 
                new TestModel() { 
                    key = 1, name = "AA" }, 
                new TestModel() { 
                    key = 2, name = "BB" }};

            builderDataGrid = new BuilderDataGrid();
            testDataGrid = builderDataGrid
                .activate(this, "testDataGrid_dg")
                .setColumnDataBinding(header, properties, datas);

            MyList<string> testDataForList = new MyList<string>() { 
                "TEST1", "TEST2", "TEST3", "TEST4", "TEST5", "TEST6" };

            //builderListBox = new BuilderListBox();
            //testListBox = builderListBox
            //    .activate(this, "testListBox_lsb")
            //    .setItemList(testDataForList);

            builderListView = new BuilderListView();
            testListView = builderListView
                .activate(this, "testListView_lsv")
                .addGridViewColumns(header,properties)
                .addItems(datas)
                .addOnSelectionChanged(this, "testListViewMethod");

            builderPasswordBox = new BuilderPasswordBox();
            testPasswordBox = builderPasswordBox
                .activate(this, "testPasswordBox_pb");

            builderProgressBar = new BuilderProgressBar();
            testProgressBar = builderProgressBar
                .activate(this, "testProgressBar_pgsb")
                .animate(1,100);

            MyList<double> chartDataExample = new MyList<double>() { 10, 20, 30, 40 };
            MyList<double> chartDataExample2 = new MyList<double>() { 40,30,20,10 };
            builderLineChart = new BuilderLineChart();
            lineChart = builderLineChart
                .activate(this, "lineChart_lc")
                .addSeries("Series1", chartDataExample)
                .addSeries("Series2", chartDataExample2)
                .changeSeriesFillColor("Series1", "#FFFF00")
                .changeSeriesLineColor("Series1", "#FFFF00");
        }

        public void testMethod() {
            this.Close();
        }

        public void testListViewMethod(TestModel _clickedObject) {
            Console.WriteLine((_clickedObject).name);
        }
    }
}
