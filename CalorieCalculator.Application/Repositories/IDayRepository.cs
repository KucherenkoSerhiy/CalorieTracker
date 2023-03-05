using CalorieCalculator.Application.Models;

namespace CalorieCalculator.Application.Repositories;

public interface IDayRepository
{
    Task<Day?> GetDayAsync(DateTime date);
    Task<IReadOnlyCollection<Day>> GetDaysAsync(DateTime startDate, DateTime endDate);
    Task SaveDayAsync(Day day);
}