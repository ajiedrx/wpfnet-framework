using MyFramework.basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.chart.worldchart
{
    public class BuilderWorldMapChart
    {
        public IMyWorldMapChart activate(IMyContainer _parent, string _componentName) {
            Object obj = _parent.getComponentByName(_componentName);
            IMyWorldMapChart radarChart = new MyWorldMapChart(((IMyContainer)obj).getComponentByName("worldMapChart_chr"));
            return radarChart;
        }
    }
}
