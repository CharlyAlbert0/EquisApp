using AutoMapper;
using DataService.DomainModels;
using DataService.DTOs.Common;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Core.ApplicationServices
{
    public static class MapperSpecialService
    {    

        public static List<User> UserMap(List<UserModel> model)
        {
            var list = Mapper.Map<List<User>>(model);
            var temp = new List<UserModel>();
            foreach (var a in list)
            {
                temp = model.Where(t => t.UserId == a.UserId).ToList();

            }

            return list;
        }

        public static User UserMap(UserModel model)
        {
            return Mapper.Map<User>(model);           

             
        }


    }
}
