using System.Collections.Generic;
using System.Threading.Tasks;
using Poli.Arqsoftware.DistribucionesSasApp.Core.DTOs;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Entity;

namespace Poli.Arqsoftware.DistribucionesSasApp.Core.Domain
{
    public interface IPersonDomain
    {
        Task<int> CreatePersonAsync(PersonDto person);

        Task<bool> UpdatePersonAsync(int id, PersonDto person);

        Task<bool> ChangePersonStateAsync(int id, bool enable);

        Task<PersonEntity> GetPersonByDocNumberAsync(int docNumber);

        Task<IEnumerable<PersonEntity>> GetAllPeopleAsync();
    }
}
