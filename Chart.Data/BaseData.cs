using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Data
{
    public abstract class BaseData
    {
        protected static string GetCacheKey(params object[] list)
        {
            string key = string.Empty;
            foreach (var item in list)
                key += item.ToString();
            return key;
        }
    }
}
