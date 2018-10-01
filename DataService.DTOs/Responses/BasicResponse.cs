namespace DataService.DTOs.Responses
{
    public class BasicResponse : IBasicResponse
    {
        public string ReturnCode { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }

        public BasicResponse()
            : this("0", "", "")
        {
        }

        public BasicResponse(BasicResponse basicResponse) : this(
            basicResponse?.ReturnCode ?? "0",
            basicResponse?.Message,
            basicResponse?.Description
        )
        {
        }

        public BasicResponse(string returnCode, string message, string description)
        {
            this.ReturnCode = returnCode;
            this.Message = message;
            this.Description = description;
        }
    }
}
