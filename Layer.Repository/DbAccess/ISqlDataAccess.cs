using Layer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId="DbLOGO");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "DbLOGO");
        Task<IEnumerable<T>> QueryGetList<T>(string query,string connectionId="DbLOGO");
    }
}
