using InternalService.InitialLoad.Contracts.Model;

namespace InternalService.InitialLoad.Contracts
{
    public interface IProviderCacheManager
    {
        CacheOperationResultModel InitializeProviderCache();

        CacheOperationResultModel AddNotRemovableItem<T>(string key, T item)
           where T : class, new();

        CacheOperationResultModel AddItem<T>(string key, T item)
            where T : class, new();

        T GetItem<T>(string key)
           where T : class, new();

        CacheOperationResultModel RemoveItem(string key);

        CacheOperationResultModel ClearCache();
    }
}
