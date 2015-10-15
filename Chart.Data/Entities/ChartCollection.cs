using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Data.Entities
{
    public class ChartCollection
    {
        public string formatid { get; set; }
        public string formatName { get; set; }
        public int chartSize { get; set; }
        public DateTime issue_date { get; set; }
        public int row_count { get; set; }
        public List<Chart> items { get; set; }
    }
}
