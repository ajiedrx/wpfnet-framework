using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.piechart
{
    public class BuilderPieChart
    {
        public IMyPieChart activate(IMyContainer _parent, string _componentName)
        {
            Object obj = _parent.getComponentByName(_componentName);
            IMyPieChart pieChart = new MyPieChart(((IMyContainer)obj).getComponentByName("pieChart_chr"));
            return pieChart;
        }
    }
}
