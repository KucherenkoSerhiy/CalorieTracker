using System.Threading.Tasks;
using CalorieTracker.Application.Models;
using CalorieTracker.Application.Repositories;

namespace CalorieTracker.Application.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public async Task<Person> GetPersonAsync()
        {
            var person = await personRepository.GetPersonAsync();
            if (person != null) return person;
        
            person = new Person();
            await personRepository.SavePersonAsync(person);
            return person;
        }
    }
}