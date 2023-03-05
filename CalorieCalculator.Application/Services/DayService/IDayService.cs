using CalorieCalculator.Application.Models;

namespace CalorieCalculator.Application.Services.DayService;

public interface IDayService
{
    Task<Day> GetOrCreateDayAsync(DateTime date);
    Task<IReadOnlyCollection<Day>> GetLastNDays(int n);
    Task<IReadOnlyCollection<Day>> GetMonth(DateTime month);
    Task SaveDayAsync(Day day);
}