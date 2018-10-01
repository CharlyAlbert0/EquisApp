using System.ServiceModel;
using DataService.Core;
using DataService.DTOs.Common;
using DataService.DTOs.Requests;
using DataService.DTOs.Responses;

namespace DataService.API
{
    [ServiceContract]
    public class DataServiceApi : IDataService
    {
      

        #region Users
        [OperationContract]
        public GetUserResponse GetUsers(BasicRequest request)
        {
            var service = new ResourcesService();
            return service.GetUsers(request);
        }

        [OperationContract]
        public void CreateUpdateUser(User request)
        {
            var service = new ResourcesService();
            service.CreateUpdateUser(request);
        }
        #endregion


    }
}