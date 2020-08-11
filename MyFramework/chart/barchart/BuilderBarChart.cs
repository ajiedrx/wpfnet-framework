using MyFramework.basic;
using System;

namespace MyFramework.chart.barchart
{
    public class BuilderBarChart
    {
        public BuilderBarChart() { }
        public IMyBarChart activate(IMyContainer _parent, string _componentName) {
            Object obj = _parent.getComponentByName(_componentName);
            IMyBarChart barChart = new MyBarChart(((IMyContainer)obj).getComponentByName("barChart_chr"));
            return barChart;
        }
    }
}
