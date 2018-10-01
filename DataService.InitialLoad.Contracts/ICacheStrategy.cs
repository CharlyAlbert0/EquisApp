using InternalService.InitialLoad.Contracts.Model;

namespace InternalService.InitialLoad.Contracts
{
    public interface ICacheStrategy
    {
        CacheOperationResultModel InitializeProviderCache<C>(C cacheProvider)
            where C : IProviderCacheManager, new();

        CacheOperationResultModel AddNotRemovableItemToCache<C, T>(string key, T item, C cacheProvider)
            where T : class, new()
            where C : IProviderCacheManager, new();

        CacheOperationResultModel AddItemToCache<C, T>(string key, T item, C cacheProvider)
            where T : class, new()
            where C : IProviderCacheManager, new();

        T GetItemFromCache<C, T>(string key, C cacheProvider)
            where T : class, new()
            where C : IProviderCacheManager, new();

        CacheOperationResultModel RemoveItemFromCache<C>(string key, C cacheProvider)
            where C : IProviderCacheManager, new();

        CacheOperationResultModel ClearCache<C>(C cacheProvider)
            where C : IProviderCacheManager, new();
    }
}
