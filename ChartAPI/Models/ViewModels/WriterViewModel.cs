using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chart.API.Models.ViewModels
{
    public class WriterViewModel
    {
        public long WriterID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}