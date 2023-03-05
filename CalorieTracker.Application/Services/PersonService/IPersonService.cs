using System.Threading.Tasks;
using CalorieTracker.Application.Models;

namespace CalorieTracker.Application.Services.PersonService
{
    public interface IPersonService
    {
        Task<Person> GetPersonAsync();
    }
}