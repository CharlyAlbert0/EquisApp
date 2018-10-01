using System.Runtime.Serialization;

namespace InternalService.InitialLoad.Contracts.Model
{
    [DataContract]
    public class CacheOperationResultModel
    {
        /// <summary>
        /// True: sucess
        /// False: Controlled Error
        /// Null: Unexpected Error: timeouts, server is off, etc..
        /// </summary>
        [DataMember]
        public bool? Resultado { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string StackTraceMessage { get; set; }

        public CacheOperationResultModel()
        {
            Resultado = null;
        }
    }
}
