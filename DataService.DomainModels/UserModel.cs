
namespace DataService.DomainModels
{
    public class UserModel
    {
        #region Constructor

        public UserModel()
        {
            UserLogin = "";
            UserId = 0;
            Password = "";
            Salt = "";
            Gender = 1;
            Email = "";
            Status = false;     
        }

        #endregion

        #region Properties

        public string UserLogin { get; set; }

        public int UserId { get; set; }
        
        public string Password { get; set; }

        public string Salt { get; set; }

        public int Gender { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public int ReturnCode { get; set; }

        public string ReturnString { get; set; }

        #endregion
    }
}
