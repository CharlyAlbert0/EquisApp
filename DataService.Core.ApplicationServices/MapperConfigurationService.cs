using AutoMapper;
using DataService.DomainModels;
using DataService.DTOs.Common;

namespace DataService.Core.ApplicationServices
{
    public static class MapperConfigurationService
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {                              
                cfg.CreateMap<UserModel, User>();
            });
        }
    }
}
