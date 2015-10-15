using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Data.Entities
{
    public class Artist
    {
        public int artistid { get; set; }
        public int titleid { get; set; }
        public string artistname { get; set; }
        public int seq { get; set; }
        public decimal credit { get; set; }
    }
}
