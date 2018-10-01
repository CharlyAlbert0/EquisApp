using System;
using Tnc.Log.Core.ApplicationServices.Helper;
using Tnc.Log.Core.VerticalServices.DTOs;
using Tnc.Log.Core.VerticalServices.Enum;
using DataService.DTOs.Requests;
using DataService.DTOs.Responses;
using DataService.VerticalServices;
using DataService.DTOs.Common;
using DataService.Core.ApplicationServices;

namespace DataService.Core
{
    public class ResourcesService : ResourcesServiceBase
    {
        private const string AppName = "DataService";

        #region Users   


        public GetUserResponse GetUsers(BasicRequest request)
        {
            var mainLog = new LogServiceHelper(AppName, "GetUsers", string.Empty,"", string.Empty);
            var serializedObject = XmlSerializerService.Serialize(request);
            mainLog.Add(new ProcessLogDetailDto("Request", serializedObject, LogType.INFO));

            var response = new GetUserResponse();
            try
            {

                var list = GetUsersData();

                response.Users = list;
                response.ReturnCode = "1000";
                response.Message = "Operation succesfully completed";
            }
            catch (Exception ex)
            {
                response.ReturnCode = "19999";
                response.Message = ex.Message;
                serializedObject = XmlSerializerService.Serialize(response);
                mainLog.Add(new ProcessLogDetailDto($"Response - Exception: {ex}", serializedObject, LogType.ERROR));
                mainLog.Save();

                return response;
            }

            serializedObject = XmlSerializerService.Serialize(response);
            mainLog.Add(new ProcessLogDetailDto("Response", serializedObject, LogType.INFO));
            mainLog.Save();

            return response;
        }


        public BasicResponse CreateUpdateUser(User request)
        {
            var mainLog = new LogServiceHelper(AppName, "CreateUpdateUser", string.Empty, "", string.Empty);
            var serializedObject = XmlSerializerService.Serialize(request);
            mainLog.Add(new ProcessLogDetailDto("Request", serializedObject, LogType.INFO));

            var response = new BasicResponse();
            try
            {
               
                CreateUpdateUserData(request);

                response.ReturnCode = "1000";
                response.Message = "Operation succesfully completed";
            }
           
            catch (Exception ex)
            {
                response.ReturnCode = "19999";
                response.Message = ex.Message;
                serializedObject = XmlSerializerService.Serialize(response);
                mainLog.Add(new ProcessLogDetailDto($"Response - Exception: {ex}", serializedObject, LogType.ERROR));
                mainLog.Save();

                return response;
            }

            serializedObject = XmlSerializerService.Serialize(response);
            mainLog.Add(new ProcessLogDetailDto("Response", serializedObject, LogType.INFO));
            mainLog.Save();

            return response;
        }


        #endregion

    }
}
