
using AutoMapper;
using System;
using System.Collections.Generic;
using DataService.Core.ApplicationServices;
using DataService.DomainModels;
using DataService.DTOs.Common;
using DataService.VerticalServices;

namespace DataService.Core
{
    public class ResourcesServiceBase
    {
        #region Users
       
        

        public List<User> GetUsersData()
        {
            try
            {
                var appService = new CoreApplicationService();
                List<UserModel> modelList = appService.GetUsers();

                var list = Mapper.Map<List<User>>(modelList);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obtaining users ", ex);
            }
        }

        public void CreateUpdateUserData(User model)
        {
            try
            {
                var appService = new CoreApplicationService();
                appService.CreateUpdateUser(Mapper.Map<UserModel>(model));
            }
            catch (Exception ex)
            {
                throw new Exception("Error CreateUpdateUserDate", ex);
            }
        }


        #endregion











    }
}
