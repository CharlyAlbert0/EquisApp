
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataService.DomainModels;

namespace DataService.ModelServices
{
    public class CatalogsModelService
    {
        private readonly SqlConnection _connection;

        public CatalogsModelService()
        {
            _connection = DbFactory.CreateConnection();
        }

       

    }
}
