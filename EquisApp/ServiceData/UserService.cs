using EquisApp.DataServiceReference;
using EquisApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquisApp.ServiceData
{
    public class UserService
    {
        public GetUserResponse GetUsers()
        {
            var req = new BasicRequest();            
            var proxy = ServiceUtil.GetProxy();

            return proxy.GetUsers(req);

            //proxy.GetUsersCompleted += (s, e) =>
            //{
            //    try
            //    {
            //        try { proxy.Close(); }
            //        catch (Exception) { proxy.Abort(); }
            //        if (e.Error == null)
            //        {
            //            message(e.Result);
            //        }
            //        else
            //        {
            //            //ServiceLogger.WriteError(ServiceUtil.UnexpectedErrorMessage(this.ToString(), "GetChecksForSearchChecksScreen"), e.Error, LogPriority.Low);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        //ServiceLogger.WriteError(ServiceUtil.UnexpectedErrorMessage(this.ToString(), "GetChecksForSearchChecksScreen"), ex, LogPriority.Low);
            //    }
            //};
            //proxy.GetUsersAsync(req);
        }
    }
}