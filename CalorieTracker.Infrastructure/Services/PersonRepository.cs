using System.Threading.Tasks;
using CalorieTracker.Application.Models;
using CalorieTracker.Application.Repositories;
using CalorieTracker.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Infrastructure.Services
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext dataContext;

        public PersonRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Person?> GetPersonAsync()
        {
            return await dataContext.People.FirstOrDefaultAsync();
        }

        public async Task SavePersonAsync(Person person)
        {
            await dataContext.People.AddAsync(person);
            await dataContext.SaveChangesAsync();
        }
    }
}