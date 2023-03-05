using CalorieCalculator.Application.Models;

namespace CalorieCalculator.Application.Repositories;

public interface IPersonRepository
{
    Task<Person?> GetPersonAsync();
    Task SavePersonAsync(Person person);
}