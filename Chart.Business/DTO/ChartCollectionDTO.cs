using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Business.DTO
{
    public class ChartCollectionDTO
    {
        public int total { get; set; }
        public string format_id { get; set; }
        public string chart_name { get; set; }
        public DateTime chart_date { get; set; }
        public List<ChartDTO> items { get; set; }
    }
}
