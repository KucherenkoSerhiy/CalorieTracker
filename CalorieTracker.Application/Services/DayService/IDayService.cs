using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CalorieTracker.Application.Models;

namespace CalorieTracker.Application.Services.DayService
{
    public interface IDayService
    {
        Task<Day> GetOrCreateDayAsync(DateTime date);
        Task<List<Day>> GetLastNDays(int n);
        Task<List<Day>> GetMonth(DateTime month);
        Task SaveDayAsync(Day day);
    }
}