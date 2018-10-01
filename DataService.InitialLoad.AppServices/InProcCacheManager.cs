using System;
using System.Runtime.Caching;
using InternalService.InitialLoad.Contracts;
using InternalService.InitialLoad.Contracts.Model;

namespace InternalService.InitialLoad.AppServices
{
    public class InProcCacheManager : IProviderCacheManager
    {
        private static readonly InProcCacheManager _instance = new InProcCacheManager();
        public static InProcCacheManager Instance => _instance;

        /// <summary>
        /// Absolute Expiration: The default value is InfiniteAbsoluteExpiration, meaning that the entry does not expire.
        /// SlidingExpiration: he default is NoSlidingExpiration, meaning that the item should not be expired based on a time span.
        /// </summary>
        private readonly CacheItemPolicy _defaultPolicy = new CacheItemPolicy { Priority = CacheItemPriority.NotRemovable };

        /// <summary>
        /// Access this only if you want to do advanced operations
        /// </summary>
        public MemoryCache DefaultCache => MemoryCache.Default;

        /// <summary>
        /// Absolute Expiration: The default value is InfiniteAbsoluteExpiration, meaning that the entry does not expire.
        /// SlidingExpiration: he default is NoSlidingExpiration, meaning that the item should not be expired based on a time span.
        /// </summary>
        public CacheItemPolicy DefaultPolicy => _defaultPolicy;

        private InProcCacheManager()
        {
            InitializeProviderCache();
        }

        /// <summary>
        /// This recycles the Default Cache, usually you don't use this at least you explicit want to clear all cache
        /// in order to load data
        /// </summary>
        /// <returns></returns>
        public CacheOperationResultModel InitializeProviderCache()
        {
            CacheOperationResultModel result = new InitializeOperationResultModel();
            try
            {
                MemoryCache.Default.Trim(100);
                result.Resultado = true;
                result.Message = "Ok";
                return result;
            }
            catch (Exception ex)
            {
                //todo log
                result.Resultado = false;
                result.Message = "Error al inicializar NCache";
                result.StackTraceMessage = ex.StackTrace;

                return result;
            }
        }

        /// <summary>
        /// Adds item with default Policy
        /// The Add method overloads try to insert a cache entry into the cache, without overwriting or removing an existing cache entry that has the same key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public CacheOperationResultModel AddItem<T>(string key, T item) where T : class, new()
        {
            try
            {
                var cacheItem = new CacheItem(key, item);
                MemoryCache.Default.Add(cacheItem, _defaultPolicy);

                return new CacheOperationResultModel { Resultado = true, Message = "Ok" };
            }
            catch (Exception ex)
            {
                //todo log                
                return new CacheOperationResultModel { Resultado = false, Message = ex.Message, StackTraceMessage = ex.StackTrace };
            }
        }
        /// <summary>
        /// The Add method overloads try to insert a cache entry into the cache, without overwriting or removing an existing cache entry that has the same key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="policy"></param>
        /// <returns></returns>
        public CacheOperationResultModel AddItem<T>(string key, T item, CacheItemPolicy policy) where T : class, new()
        {
            try
            {
                var cacheItem = new CacheItem(key, item);
                MemoryCache.Default.Add(cacheItem, policy);

                return new CacheOperationResultModel { Resultado = true, Message = "Ok" };
            }
            catch (Exception ex)
            {
                //todo log                
                return new CacheOperationResultModel { Resultado = false, Message = ex.Message, StackTraceMessage = ex.StackTrace };
            }
        }

        /// <summary>
        /// The Add method overloads try to insert a cache entry into the cache, without overwriting or removing an existing cache entry that has the same key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public CacheOperationResultModel AddNotRemovableItem<T>(string key, T item) where T : class, new()
        {
            try
            {
                return AddItem(key, item);
            }
            catch (Exception ex)
            {
                //todo log                
                return new CacheOperationResultModel { Resultado = false, Message = ex.Message, StackTraceMessage = ex.StackTrace };
            }
        }

        /// <summary>
        /// Save (Set) method overloads, the Set method always puts a cache value in the cache, 
        /// regardless whether an entry already  exists with the same key. 
        /// If the specified entry does not exist, a new cache entry is inserted. 
        /// If the specified entry exists, it is updated.
        /// </summary>
        /// <returns></returns>
        public CacheOperationResultModel SaveItem<T>(string key, T item, CacheItemPolicy policy)
            where T : class, new()
        {
            try
            {
                MemoryCache.Default.Set(key, item, policy);
                return new CacheOperationResultModel { Resultado = true, Message = "Ok" };
            }
            catch (Exception ex)
            {
                //todo log
                return new CacheOperationResultModel { Resultado = false, Message = ex.Message, StackTraceMessage = ex.StackTrace };
            }
        }

        /// <summary>
        /// Gets item of specified T Type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetItem<T>(string key) where T : class, new()
        {
            try
            {
                return (T)MemoryCache.Default.Get(key);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CacheOperationResultModel RemoveItem(string key)
        {
            try
            {
                MemoryCache.Default.Remove(key);
                return new CacheOperationResultModel { Resultado = true, Message = "Ok" };
            }
            catch (Exception ex)
            {
                return new CacheOperationResultModel { Resultado = false, Message = ex.Message, StackTraceMessage = ex.StackTrace };
            }
        }

        /// <summary>
        /// tries to clear cache
        /// </summary>
        /// <returns></returns>
        public CacheOperationResultModel ClearCache()
        {
            try
            {
                MemoryCache.Default.Trim(100);
                if (MemoryCache.Default.GetCount() > 0)
                    MemoryCache.Default.Trim(100);

                return new CacheOperationResultModel { Resultado = true, Message = "Ok" };
            }
            catch (Exception ex)
            {
                //todo log                
                return new CacheOperationResultModel { Resultado = false, Message = ex.Message, StackTraceMessage = ex.StackTrace };
            }
        }
    }
}
