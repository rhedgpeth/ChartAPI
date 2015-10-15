using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Chart.API.Models;
using Chart.API.Models.ViewModels;

using Chart.Business.DTO;
using Chart.Business.Services;

using AutoMapper;

namespace Chart.API.Controllers
{
    //[RoutePrefix("charts")]

    /// <summary>
    /// Billboard Charts Controller
    /// </summary>
    public class ChartsController : ApiController
    {
        /// <summary>
        /// This is a bad ass custom description. OK, it's not bad ass, but it is a description.
        /// </summary>
        public DataResponse<ChartCollectionDTO> GetTop100_V1(string formatID, DateTime chartDate)
        {
            DataResponse<ChartCollectionDTO> result = new DataResponse<ChartCollectionDTO>();

            result.Data = ChartService.GetHot100(formatID, chartDate);
            result.Success = true;

            return result;
        }

        [Route("badassroute")]
        [Route("charts/top_100")]
        public DataResponse<ChartCollectionDTO> GetTop100_V2(string formatID, DateTime chartDate)
        {
            DataResponse<ChartCollectionDTO> result = new DataResponse<ChartCollectionDTO>();

            result.Data = ChartService.GetHot100(formatID, chartDate);
            result.Success = true;

            return result;
        }

        [Route("api/charts/top_100")]
        public DataResponse<ChartResponse> GetTop100_V3(string formatID, DateTime chartDate)
        {
            DataResponse<ChartResponse> result = new DataResponse<ChartResponse>();

            result.Data = Mapper.Map<ChartCollectionDTO, ChartResponse>(ChartService.GetHot100(formatID, chartDate));
            result.Success = true;

            return result;
        }
    }
}
