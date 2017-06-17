using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodChart.Models
{
    public class ChartProviderPaid : IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new PieChart();
            return chart;
        }
    }
}