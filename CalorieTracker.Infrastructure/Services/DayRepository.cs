using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalorieTracker.Application.Models;
using CalorieTracker.Application.Repositories;
using CalorieTracker.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Infrastructure.Services
{
    public class DayRepository : IDayRepository
    {
        private readonly DataContext dataContext;

        public DayRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Day?> GetDayAsync(DateTime date)
        {
            return await dataContext.Days
                .Include(d => d.ConsumedProducts)
                .Include(d => d.PerformedExercises)
                .FirstOrDefaultAsync(d => d.Date == date);
        }

        public async Task<List<Day>> GetDaysAsync(DateTime startDate, DateTime endDate)
        {
            return await dataContext.Days
                .Include(d => d.ConsumedProducts)
                .Include(d => d.PerformedExercises)
                .Where(d => d.Date >= startDate && d.Date < endDate).ToListAsync();
        }

        public async Task SaveDayAsync(Day day)
        {
            await dataContext.Days.AddAsync(day);
            await dataContext.SaveChangesAsync();
        }
    }
}