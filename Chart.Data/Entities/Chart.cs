using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Data.Entities
{
    public class Chart
    {
        public string rank { get; set; }
        public string rank_lw { get; set; }
        public string rank_2w { get; set; }
        public DateTime date { get; set; }
        public string artistname { get; set; }
        public string title { get; set; }
        public string bullet { get; set; }
        public string formatid { get; set; }
        public int artistid { get; set; }
        public int titleid { get; set; }
        public string charttitle { get; set; }
        public int chartweeks { get; set; }
        public string displaylabel { get; set; }
        public string displaydistlabel { get; set; }
        public int peakpos { get; set; }
        public int debutpos { get; set; }
        public DateTime peakdate { get; set; }
        public DateTime debutdate { get; set; }
        public string feature_code { get; set; }
        public bool has_bullet { get; set; }
        public bool has_bullet_desc { get; set; }
        public bool has_lw_bullet_desc { get; set; }
        public bool has_2w_bullet_desc { get; set; }
        public string writer_desc { get; set; }
        public string writer_short_desc { get; set; }
        public string producer_desc { get; set; }
        public string producer_short_desc { get; set; }

        public List<Artist> credited_artists { get; set; }
        public List<Producer> credited_producers { get; set; }
        public List<Writer> credited_writers { get; set; }
    }
}
