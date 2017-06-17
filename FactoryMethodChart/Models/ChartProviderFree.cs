using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodChart.Models
{
    public class ChartProviderFree : IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new BarChart();
            return chart;
        }
    }
}