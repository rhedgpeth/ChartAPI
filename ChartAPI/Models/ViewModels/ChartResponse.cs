using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Chart.Business.DTO;

namespace Chart.API.Models.ViewModels
{
    public class ChartResponse
    {
        public int Total { get; set; }
        public string FormatID { get; set; }
        public string ChartName { get; set; }
        public DateTime IssueDate { get; set; }
        public List<ChartViewModel> Items { get; set; }
    }
}