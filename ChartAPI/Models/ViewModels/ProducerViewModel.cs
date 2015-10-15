using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chart.API.Models.ViewModels
{
    public class ProducerViewModel
    {
        public long ProducerID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}