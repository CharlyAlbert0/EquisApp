
namespace InternalService.InitialLoad.Contracts.Model
{
    public class InitializeOperationResultModel : CacheOperationResultModel
    {
        public bool IsMainCacheInitialized { get; set; }
        public string MainCacheResultMessage { get; set; }

        public bool IsSecondaryCacheInitialized { get; set; }
        public string SecondaryCacheResultMessage { get; set; }
    }
}
