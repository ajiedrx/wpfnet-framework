using MyFramework.basic;
using System.Collections.ObjectModel;
using System.Windows.Media;
using WpfCharts;

namespace MyFramework.chart.radarchart
{
    /// <summary>
    /// Interaction logic for RadarChart.xaml
    /// </summary>
    public partial class RadarChart : MyUserControl
    {
        public RadarChart() {
            InitializeComponent();
            //MyList<double> dt = new MyList<double>() { 12,30,40 };
            //radarChart_chr.Axis = new MyList<string>() { "1", "2", "3" };
            //radarChart_chr.Lines = new ObservableCollection<ChartLine>() { new ChartLine() { 
            //    LineColor = Colors.Black,
            //    Name = "hehe",
            //    PointDataSource = dt
            //} };
        }
    }
}
