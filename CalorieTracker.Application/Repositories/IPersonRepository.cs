using System.Threading.Tasks;
using CalorieTracker.Application.Models;

namespace CalorieTracker.Application.Repositories
{
    public interface IPersonRepository
    {
        Task<Person?> GetPersonAsync();
        Task SavePersonAsync(Person person);
    }
}