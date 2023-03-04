using CalorieCalculator.Application.Models;

namespace CalorieCalculator.Application.Services.DayService;

public interface IDayService
{
    Task<Day> GetOrCreateDayAsync(DateTime date);
    Task<List<Day>> GetLastNDays(int n);
    Task<List<Day>> GetMonth(DateTime month);
    Task SaveDayAsync(Day day);
}