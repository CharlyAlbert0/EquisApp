
using InternalService.InitialLoad.Contracts;
using InternalService.InitialLoad.Contracts.Model;

namespace InternalService.InitialLoad.AppServices
{
    internal class CacheStrategy : ICacheStrategy
    {
        public CacheOperationResultModel InitializeProviderCache<C>(C cacheProvider) where C : IProviderCacheManager, new()
        {
            return cacheProvider.InitializeProviderCache();
        }

        public CacheOperationResultModel AddNotRemovableItemToCache<C, T>(string key, T item, C cacheProvider) where C : IProviderCacheManager, new() where T : class, new()
        {
            return cacheProvider.AddNotRemovableItem(key, item);
        }

        public CacheOperationResultModel AddItemToCache<C, T>(string key, T item, C cacheProvider) where C : IProviderCacheManager, new() where T : class, new()
        {
            return cacheProvider.AddItem(key, item);
        }

        public T GetItemFromCache<C, T>(string key, C cacheProvider) where C : IProviderCacheManager, new() where T : class, new()
        {
            return cacheProvider.GetItem<T>(key);
        }

        public CacheOperationResultModel RemoveItemFromCache<C>(string key, C cacheProvider) where C : IProviderCacheManager, new()
        {
            return cacheProvider.RemoveItem(key);
        }

        public CacheOperationResultModel ClearCache<C>(C cacheProvider) where C : IProviderCacheManager, new()
        {
            return cacheProvider.ClearCache();
        }
    }
}
