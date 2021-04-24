using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Poli.Arqsoftware.DistribucionesSasApp.Core.DataAccess;
using Poli.Arqsoftware.DistribucionesSasApp.Core.DTOs;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Entity;

namespace Poli.Arqsoftware.DistribucionesSasApp.Core.Repository
{
   

    internal class PersonRepository : IPersonRepository
    {
        private readonly ISqlServer _dataAccess;

        public PersonRepository(ISqlServer dataAccess)
        {
            _dataAccess = dataAccess;
        }


        public Task<bool> ChangeStateAsync(int id, bool enable)
        {
            string storedProcedure = "[dbo].[sp_ChangePersonState]";
            var parameters = new
            {
                Enable = enable
            };

            return _dataAccess.ExecuteSingleQueryAsync<bool>(storedProcedure, parameters);
        }

        public Task<int> CreateAsync(PersonDto person)
        {
            string storedProcedure = "[dbo].[sp_CreatePerson]";
            var parameters = new
            {
                person.DocNumber,
                person.Enable,
                person.FirstName,
                person.LastName,
            };

            return _dataAccess.ExecuteSingleQueryAsync<int>(storedProcedure, parameters);
        }

        public Task<IEnumerable<PersonEntity>> GetAllAsync()
        {
            string storedProcedure = "[dbo].[sp_GetAllPeople]";
           
            return _dataAccess.ExecuteQueryAsync<PersonEntity>(storedProcedure);
        }

        public Task<PersonEntity> GetByIdAsync(int id)
        {
            string storedProcedure = "[dbo].[sp_GetPersonById]";
            var parameters = new
            {
                Id = id
            };

            return _dataAccess.ExecuteSingleQueryAsync<PersonEntity>(storedProcedure, parameters);
        }

        public Task<bool> UpdateAsync(int id, PersonDto person)
        {
            string storedProcedure = "[dbo].[sp_UpdatePerson]";
            var parameters = new
            {
                Id = id,
                person.DocNumber,
                person.Enable,
                person.FirstName,
                person.LastName,
            };

            return _dataAccess.ExecuteSingleQueryAsync<bool>(storedProcedure, parameters);
        }
    }
}
