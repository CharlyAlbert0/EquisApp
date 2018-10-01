using System.Collections.Generic;
using DataService.DomainModels;
using DataService.ModelServices;
using System;
using DataService.DTOs.Common;

namespace DataService.Core.ApplicationServices
{
    public class CoreApplicationService
    {
        
        #region User
        public List<UserModel> GetUsers()
        {
            var modelService = new CoreModelService();
            return modelService.GetUsers();
        }
        
        public  void CreateUpdateUser(UserModel model)
        {
            var modelService = new CoreModelService();
            modelService.CreateUpdateUser(model);
        }
        #endregion


    }
}
