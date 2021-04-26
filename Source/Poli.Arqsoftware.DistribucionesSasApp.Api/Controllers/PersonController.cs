using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Domain;
using Poli.Arqsoftware.DistribucionesSasApp.Core.DTOs;
using Poli.Arqsoftware.DistribucionesSasApp.Core.Entity;

namespace Poli.Arqsoftware.DistribucionesSasApp.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IPersonDomain _personDomain;

        public PersonController(IPersonDomain personDomain)
        {
            _personDomain = personDomain;
        }


   
        [HttpGet]
        public Task<IEnumerable<PersonEntity>> Get()
        {
            return _personDomain.GetAllPeopleAsync();
        }

        // GET api/values/5
        [HttpGet("{docNumber}")]
        public Task<PersonEntity> Get(int docNumber)
        {
            return _personDomain.GetPersonByDocNumberAsync(docNumber);
        }

        // POST api/values
        [HttpPost]
        public Task<int> Post([FromBody] PersonDto person)
        {
            return _personDomain.CreatePersonAsync(person);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Task<bool> Put([FromRoute] int id, [FromBody] PersonDto person)
        {
            return _personDomain.UpdatePersonAsync(id, person);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Task<bool> Delete(int id)
        {
            return _personDomain.ChangePersonStateAsync(id, false);
        }
    }
}
