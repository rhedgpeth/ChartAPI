using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chart.API.Models.ViewModels
{
    public class ArtistViewModel
    {
        public long ArtistID { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }
    }
}