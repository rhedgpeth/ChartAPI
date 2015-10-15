using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data;
using System.Data.SqlClient;
using Chart.Data.Entities;
using Chart.Core;

namespace Chart.Data
{
    public class ChartData : BaseData
    {
        private static ICache _cache = new RuntimeCache();

        internal static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Charts"].ConnectionString;

        public static ChartCollection QryApiChartIssue(string formatID, DateTime chartDate)
        {
            string cacheKey = GetCacheKey("QryApiChartIssue", formatID, chartDate);

            ChartCollection chartCollection = _cache.Get<ChartCollection>(cacheKey);

            if (chartCollection == null)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("formatid", formatID);
                    p.Add("chartDate", chartDate);

                    var grid = conn.QueryMultiple("QryApiChartIssue", p,
                                             commandType: CommandType.StoredProcedure);

                    var charts = grid.Read(typeof(Chart.Data.Entities.Chart)).Cast<Chart.Data.Entities.Chart>();
                    chartCollection = grid.Read(typeof(ChartCollection)).Cast<ChartCollection>().Single();
                    var artists = grid.Read(typeof(Artist)).Cast<Artist>();
                    var writers = grid.Read(typeof(Writer)).Cast<Writer>();
                    var producers = grid.Read(typeof(Producer)).Cast<Producer>();

                    foreach (Chart.Data.Entities.Chart chart in charts)
                    {
                        chart.credited_artists = artists.Where(x => x.titleid == chart.titleid).ToList();
                        chart.credited_producers = producers.Where(x => x.titleid == chart.titleid).ToList();
                        chart.credited_writers = writers.Where(x => x.titleid == chart.titleid).ToList();
                    }

                    chartCollection.items = charts.ToList();

                    _cache.Set<ChartCollection>(cacheKey, chartCollection);
                }
            }

            return chartCollection;
        }
    }
}
