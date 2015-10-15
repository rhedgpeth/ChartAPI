using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Core
{
    public enum CachePriority
    {
        Normal,
        Default,
        NotRemovable
    }

    public interface ICache
    {
        void Set<T>(string key, T value, int timeoutSeconds = 120);
        void Set<T>(string key, T item, int timeoutSeconds, CachePriority cacheItemPriority);
        T Get<T>(string key);
        void Remove(string key);
    }
}
