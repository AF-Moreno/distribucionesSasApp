using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Poli.Arqsoftware.DistribucionesSasApp.Core.DTOs;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Entity;

namespace Poli.Arqsoftware.DistribucionesSasApp.Core.Repository
{
    internal interface IPersonRepository
    {
        Task<int> CreateAsync(PersonDto person);

        Task<bool> UpdateAsync(int id, PersonDto person);

        Task<bool> ChangeStateAsync(int id, bool enable);

        Task<PersonEntity> GetByIdAsync(int id);

        Task<IEnumerable<PersonEntity>> GetAllAsync();
    }
}
