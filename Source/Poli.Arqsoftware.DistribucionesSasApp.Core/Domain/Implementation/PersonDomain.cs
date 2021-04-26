using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Poli.Arqsoftware.DistribucionesSasApp.Core.DTOs;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Entity;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Repository;

namespace Poli.Arqsoftware.DistribucionesSasApp.Core.Domain
{
    internal class PersonDomain : IPersonDomain
    {
        private readonly IPersonRepository _personRepository;

        public PersonDomain(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Task<bool> ChangePersonStateAsync(int id, bool enable)
        {
            return _personRepository.ChangeStateAsync(id, enable);
        }

        public Task<int> CreatePersonAsync(PersonDto person)
        {
            return _personRepository.CreateAsync(person);
        }

        public Task<IEnumerable<PersonEntity>> GetAllPeopleAsync()
        {
            return _personRepository.GetAllAsync();
        }

        public Task<PersonEntity> GetPersonByDocNumberAsync(int docNumber)
        {
            return _personRepository.GetByDocNumberAsync(docNumber);
        }

        public Task<bool> UpdatePersonAsync(int id, PersonDto person)
        {
            return _personRepository.UpdateAsync(id, person);
        }
    }
}
