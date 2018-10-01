
using DataService.DTOs.Common;
using DataService.DTOs.Requests;
using DataService.DTOs.Responses;

namespace DataService.API
{
    public interface ICoreInterface
    {
       
        #region Users
        GetUserResponse GetUsers(BasicRequest request);
        void CreateUpdateUser(User request);
        #endregion




    }
}
