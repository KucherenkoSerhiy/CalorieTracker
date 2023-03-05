using CalorieCalculator.Application.Models;
using CalorieCalculator.Application.Repositories;
using CalorieCalculator.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CalorieCalculator.Infrastructure.Services;

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
            .Include(d => d.Consumed)
            .Include(d => d.Performed)
            .FirstOrDefaultAsync(d => d.Date == date);
    }

    public async Task<List<Day>> GetDaysAsync(DateTime startDate, DateTime endDate)
    {
        return await dataContext.Days
            .Include(d => d.Consumed)
            .Include(d => d.Performed)
            .Where(d => d.Date >= startDate && d.Date < endDate).ToListAsync();
    }

    public async Task SaveDayAsync(Day day)
    {
        await dataContext.Days.AddAsync(day);
        await dataContext.SaveChangesAsync();
    }
}