namespace DataService.DTOs.Requests
{
    public class BasicRequest : IBasicRequest
    {
        public string ServerKey { get; set; }

        public BasicRequest()
            : this("")
        {
        }

        public BasicRequest(BasicRequest basicRequest) : this(
            basicRequest?.ServerKey
        )
        {
        }

        public BasicRequest(string serverKey)
        {
            ServerKey = serverKey;
        }
    }
}
