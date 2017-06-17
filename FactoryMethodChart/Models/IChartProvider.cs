using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodChart.Models
{
    public interface IChartProvider
    {
        IChart GetChart();
    }
}
