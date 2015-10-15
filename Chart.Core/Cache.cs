using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Microsoft.Practices.EnterpriseLibrary.Caching;
//using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;

/*
namespace Chart.Core
{
    public class Cache : ICache
    {
        private readonly static ICacheManager _CacheManager = CacheFactory.GetCacheManager("Cache Manager");

        #region ICache Members

        public T Get<T>(string key)
        {
            var data = _CacheManager.GetData(key);
            return (data != null) ? (T)data : default(T);
        }

        public void Put<T>(string key, T item)
        {
            _CacheManager.Add(key, item);
        }

        public void Add<T>(string key, T value, int timeout, CachePriority cachePriority)
        {
            _CacheManager.Add(key, value, CacheItemPriority.Normal, null,
                new AbsoluteTime(DateTime.Now.Add(new TimeSpan(0, 0, timeout))));
        }

        public bool Contains(string key)
        {
            return _CacheManager.Contains(key);
        }

        public void Flush()
        {
            _CacheManager.Flush();
        }

        public void Remove(string key)
        {
            _CacheManager.Remove(key);
        }

        public void Set<T>(string key, T value)
        {
            if (_CacheManager.Contains(key))
                _CacheManager.Remove(key);

            this.Set(key, value, 120);
        }

        public void Set<T>(string key, T value, int timeoutSeconds)
        {
            if (_CacheManager.Contains(key))
                _CacheManager.Remove(key);

            this.Set(key, value, timeoutSeconds, CachePriority.Normal);
        }

        public void Set<T>(string key, T value, int timeoutSeconds, CachePriority cacheItemPriority)
        {
            if (_CacheManager.Contains(key))
                _CacheManager.Remove(key);

            this.Add(key, value, timeoutSeconds, CachePriority.Normal);
        }
        

        #endregion
    }
}
*/