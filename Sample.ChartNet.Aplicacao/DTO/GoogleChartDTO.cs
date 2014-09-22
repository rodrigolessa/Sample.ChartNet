using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ChartNet.Aplicacao.DTO
{
    public class GoogleChartDTO
    {
        public List<GoogleChartColunaDTO> cols { get; set; }
        public List<GoogleChartLinhaDTO> rows { get; set; }
    }
}
