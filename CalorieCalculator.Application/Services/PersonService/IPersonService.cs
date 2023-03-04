using CalorieCalculator.Application.Models;

namespace CalorieCalculator.Application.Services.PersonService;

public interface IPersonService
{
    Task<Person> GetPersonAsync();
}