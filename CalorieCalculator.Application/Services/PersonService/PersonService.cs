using CalorieCalculator.Application.Models;
using CalorieCalculator.Application.Repositories;

namespace CalorieCalculator.Application.Services.PersonService;

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