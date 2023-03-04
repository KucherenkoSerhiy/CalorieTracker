using CalorieCalculator.Application.Models;

namespace CalorieCalculator.Application.Services;

public interface IPersonService
{
    Task<Person> GetPersonAsync();
}