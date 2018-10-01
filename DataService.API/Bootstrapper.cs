using Autofac;
using System;
using System.Configuration;
using DataService.Core.ApplicationServices;

namespace DataService.API
{
    public class Bootstrapper
    {
        /// <summary>
        ///     Configures and builds Autofac IOC container.
        /// </summary>
        /// <returns></returns>
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // register services
            builder.RegisterType<DataServiceApi>().As<IDataService>();

            InitializeCache();
            MapperConfigurationService.Initialize();

            // build container
            return builder.Build();
        }



        public static void InitializeCache()
        {
            try
            {
                //todo implement caché data initialization             

                
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                //todo log error loading cache
            }
        }
    }
}