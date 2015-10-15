using System;
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Runtime.Caching;

namespace Chart.Core
{
    public class RuntimeCache : ICache
    { 
        // Gets a reference to the default MemoryCache instance. 
        private static ObjectCache cache = MemoryCache.Default; 
        private CacheItemPolicy policy = null; 
        private CacheEntryRemovedCallback callback = null;

        public void Set<T>(string key, T value, int timeoutSeconds = 120)
        {
            Set<T>(key, value, timeoutSeconds, CachePriority.Default);
        }

        public void Set<T>(string key, T item, int timeoutSeconds, CachePriority cacheItemPriority) 
        { 
            callback = new CacheEntryRemovedCallback(this.CachedItemRemovedCallback); 
            policy = new CacheItemPolicy(); 
            policy.Priority = (cacheItemPriority == CachePriority.Default) ? 
		            CacheItemPriority.Default : CacheItemPriority.NotRemovable; 
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(timeoutSeconds);

            // Add inside cache 
            cache.Set(key, item, policy); 
        }

        /*
        public void Set<T>(string key, T item, CachePriority cacheItemPriority, List<String> FilePath)
        {
            callback = new CacheEntryRemovedCallback(this.CachedItemRemovedCallback);
            policy = new CacheItemPolicy();
            policy.Priority = (cacheItemPriority == CachePriority.Default) ?
                    CacheItemPriority.Default : CacheItemPriority.NotRemovable;
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10.00);
            policy.RemovedCallback = callback;
            policy.ChangeMonitors.Add(new HostFileChangeMonitor(FilePath));

            // Add inside cache 
            cache.Set(key, item, policy);
        }*/

        public T Get<T>(string key) 
        {  
            return cache[key] != null ? (T)cache[key] : default(T); 
        }

        public void Remove(string key) 
        { 
            if (cache.Contains(key)) 
            { 
                cache.Remove(key); 
            } 
        }

        private void CachedItemRemovedCallback(CacheEntryRemovedArguments arguments) 
        { 
            // Log these values from arguments list 
            String strLog = String.Concat("Reason: ", arguments.RemovedReason.ToString(), @" 
            | Key-Name: ", arguments.CacheItem.Key, " | Value-Object: ", 
            arguments.CacheItem.Value.ToString()); 
            }
        } 
    }

