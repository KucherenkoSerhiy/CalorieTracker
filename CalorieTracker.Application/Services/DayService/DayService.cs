﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CalorieTracker.Application.Models;
using CalorieTracker.Application.Repositories;

namespace CalorieTracker.Application.Services.DayService
{
    public class DayService : IDayService
    {
        private readonly IDayRepository dayRepository;

        public DayService(IDayRepository dayRepository)
        {
            this.dayRepository = dayRepository;
        }

        public async Task<Day> GetOrCreateDayAsync(DateTime date)
        {
            var day = await dayRepository.GetDayAsync(date);
            if (day != null) return day;
        
            day = new Day { Date = date };
            await dayRepository.SaveDayAsync(day);
            return day;
        }

        public async Task<List<Day>> GetLastNDays(int n)
        {
            var endDate = DateTime.Today.AddDays(1);
            var startDate = endDate.AddDays(-n);
            return await dayRepository.GetDaysAsync(startDate, endDate);
        }

        public async Task<List<Day>> GetMonth(DateTime month)
        {
            var startDate = new DateTime(month.Year, month.Month, 1);
            var endDate = startDate.AddMonths(1);
            return await dayRepository.GetDaysAsync(startDate, endDate);
        }

        public async Task SaveDayAsync(Day day)
        {
            await dayRepository.SaveDayAsync(day);
        }
    }
}