using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Business.DTO
{
    public class ArtistDTO
    {
        public long billboard_artist_id { get; set; }
        public string artist_name { get; set; }
        public decimal credit { get; set; }
    }
}
