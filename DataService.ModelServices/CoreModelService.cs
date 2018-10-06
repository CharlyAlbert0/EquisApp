
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataService.DomainModels;
using System;

namespace DataService.ModelServices
{
    public class CoreModelService
    {
        private readonly SqlConnection _connection;

        public CoreModelService()
        {
            _connection = DbFactory.CreateConnection();
        }      


        #region Users
        public List<UserModel> GetUsers()
        {
            using (_connection)
            {
                var result = new List<UserModel>();
                var utilities = new ModelUtilities();
                bool HasError = false;
                string MessageOut = "";

                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = "st_GetUsers";
                    command.CommandType = CommandType.StoredProcedure;

                    var vHasError = new SqlParameter("@HasError", SqlDbType.Bit)
                    {
                        Value = HasError,
                        Direction = ParameterDirection.Output
                    };

                    var vMessageOut = new SqlParameter("@MessageOut", SqlDbType.NVarChar)
                    {
                        Value = MessageOut,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(vHasError);
                    command.Parameters.Add(vMessageOut);
                    _connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cc = new UserModel();
                            cc.UserId = utilities.GetNotNullInt(reader["UserId"]);
                            cc.UserLogin = utilities.GetString(reader["UserLogin"]);
                            cc.Password = utilities.GetString(reader["Password"]);
                            cc.Salt = utilities.GetString(reader["Salt"]);
                            cc.Status = utilities.GetNotNullBool(reader["Status"]);
                            cc.Gender = utilities.GetNotNullInt(reader["Gender"]);
                            cc.Email = utilities.GetString(reader["Email"]);

                            result.Add(cc);
                        }
                    }
                }
                return result;
            }
        }

        public void CreateUpdateUser(UserModel model)
        {      
            using (_connection)
            {
                using (var command = _connection.CreateCommand())
                {
                    command.CommandText = "st_CreateUpdateUser";
                    command.CommandType = CommandType.StoredProcedure;

                    var vUserId = new SqlParameter("@UserId", SqlDbType.Int)
                    {
                        Value = model.UserId,
                        Direction = ParameterDirection.Input
                    };

                    var vUserLogin = new SqlParameter("@UserLogin", SqlDbType.NVarChar)
                    {
                        Value = model.UserLogin,
                        Direction = ParameterDirection.Input
                    };

                    var vPassword = new SqlParameter("@Password", SqlDbType.NVarChar)
                    {
                        Value = model.Password,
                        Direction = ParameterDirection.Input
                    };

                    var vSalt = new SqlParameter("@Salt", SqlDbType.NVarChar)
                    {
                        Value = model.Salt,
                        Direction = ParameterDirection.Input
                    };

                    var vGender = new SqlParameter("@Gender", SqlDbType.Int)
                    {
                        Value = model.Gender,
                        Direction = ParameterDirection.Input
                    };

                    var vEmail = new SqlParameter("@Email", SqlDbType.NVarChar)
                    {
                        Value = model.Email,
                        Direction = ParameterDirection.Input
                    };

                    var vStatus = new SqlParameter("@Status", SqlDbType.Bit)
                    {
                        Value = model.Status,
                        Direction = ParameterDirection.Input
                    };

                    var vReturnCode = new SqlParameter("@ReturnCode", SqlDbType.NVarChar)
                    {
                        Value = model.ReturnCode,
                        Direction = ParameterDirection.Output
                    };

                    var vReturnString = new SqlParameter("@ReturnString", SqlDbType.NVarChar)
                    {
                        Value = model.ReturnString,
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(vUserId);
                    command.Parameters.Add(vUserLogin);
                    command.Parameters.Add(vPassword);
                    command.Parameters.Add(vSalt);
                    command.Parameters.Add(vGender);
                    command.Parameters.Add(vEmail);
                    command.Parameters.Add(vStatus);
                    command.Parameters.Add(vReturnCode);
                    command.Parameters.Add(vReturnString);

                    _connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion






    }
}
