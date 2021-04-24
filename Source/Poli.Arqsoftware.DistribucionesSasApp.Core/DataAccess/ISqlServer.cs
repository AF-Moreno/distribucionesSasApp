using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poli.Arqsoftware.DistribucionesSasApp.Core.DataAccess
{
    public interface ISqlServer : IDisposable
    {
        Task<IEnumerable<T>> ExecuteQueryAsync<T>(string storedProcedure, object parameters = null);

        Task<T> ExecuteSingleQueryAsync<T>(string storedProcedure, object parameters = null);
    }
}
