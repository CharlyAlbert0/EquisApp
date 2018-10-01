using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.DTOs.Common
{
    public class User
    {
        public string UserLogin { get; set; }

        public int UserId { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public int Gender { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public int ReturnCode { get; set; }

        public string ReturnString { get; set; }
    }
}
