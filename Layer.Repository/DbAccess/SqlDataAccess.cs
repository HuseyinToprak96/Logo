using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Layer.Core.Models;

namespace Layer.Repository.DbAccess
{
   public class SqlDataAccess:ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

      
        public async Task<IEnumerable<T>> QueryGetList<T>(string query, string connectionId = "DbLOGO")
        {
             IEnumerable<T> list;
            //app.setting database adı düzeltilecek
            //database adı sql de düzeltilecek
            using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId)))
            {
                connection.Open();
                list =await connection.QueryAsync<T>(query);
                connection.Close();
            }
            return list;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(
            string storedProcedure,
            U parameters, 
            string connectionId="DbLOGO")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(
             string storedProcedure,
            T parameters,
            string connectionId = "DbLOGO")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
