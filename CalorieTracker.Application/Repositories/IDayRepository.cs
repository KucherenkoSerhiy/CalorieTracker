using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CalorieTracker.Application.Models;

namespace CalorieTracker.Application.Repositories
{
    public interface IDayRepository
    {
        Task<Day?> GetDayAsync(DateTime date);
        Task<List<Day>> GetDaysAsync(DateTime startDate, DateTime endDate);
        Task SaveDayAsync(Day day);
    }
}