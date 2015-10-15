using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Chart.Business.DTO;
using Chart.Data.Entities;
using AutoMapper;

namespace Chart.Business.Services
{
    public interface IChartService
    {
        List<ChartDTO> GetHot100();
    }

    public class ChartService
    {
        public static ChartCollectionDTO GetHot100(string formatID, DateTime chartDate)
        {
            return Mapper.Map<ChartCollection, ChartCollectionDTO>(Chart.Data.ChartData.QryApiChartIssue(formatID, chartDate));
            
            //JObject o1 = JObject.Parse(File.ReadAllText(@"C:\Users\roberthedgpeth\Desktop\chartissue.json"));
            //return o1["items"].ToObject<List<ChartDTO>>();;
        }
    }
}
