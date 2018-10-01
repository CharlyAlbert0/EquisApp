using System.Collections.Generic;
using DataService.DTOs.Common;

namespace DataService.DTOs.Responses
{
    public class GetReturnCodesResponse : BasicResponse
    {
        public List<ReturnCode> ReturnCodes { get; set; }

        public GetReturnCodesResponse()
        {
        }

        public GetReturnCodesResponse(BasicResponse basicResponse) : base(basicResponse)
        {
        }
    }
}
