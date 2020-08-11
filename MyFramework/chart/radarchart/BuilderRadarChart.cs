using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.radarchart
{
    public class BuilderRadarChart
    {
        public IMyRadarChart activate(IMyContainer _parent, string _componentName) {
            Object obj = _parent.getComponentByName(_componentName);
            IMyRadarChart radarChart = new MyRadarChart(((IMyContainer)obj).getComponentByName("radarChart_chr"));
            return radarChart;
        }
    }
}
