using DataService.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.DTOs.Responses
{
    public class GetUserResponse : BasicResponse
    {
        public List<User> Users { get; set; }

        public GetUserResponse()
        {
        }

        public GetUserResponse(BasicResponse basicResponse) : base(basicResponse)
        {
        }
    }
}
