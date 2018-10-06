using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquisApp.Utils
{
    public static class ServiceUtil
    {
        public static DataServiceReference.DataServiceApiClient GetProxy()
        {
            var service = new DataServiceReference.DataServiceApiClient();           
            return service;
        }

        

        public static String UnexpectedErrorMessage(String className, String methodName)
        {
            return String.Format("Error in {0}.{1}, Unexpected error", className, methodName);
        }
    }
}