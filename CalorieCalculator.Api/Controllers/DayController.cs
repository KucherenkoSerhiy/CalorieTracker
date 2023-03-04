using CalorieCalculator.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalorieCalculator.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DayController : ControllerBase
{
    [HttpGet("last7Days")]
    public IActionResult GetLast7Days()
    {
        var today = DateTime.Today;
        var lastWeek = today.AddDays(-7);
        var days = GetDaysInRange(lastWeek, today);
        return Ok(days);
    }

    [HttpGet("last30Days")]
    public IActionResult GetLast30Days()
    {
        var today = DateTime.Today;
        var lastMonth = today.AddMonths(-1);
        var days = GetDaysInRange(lastMonth, today);
        return Ok(days);
    }

    [HttpGet("month/{year}/{month}")]
    public IActionResult GetMonth(int year, int month)
    {
        var firstDayOfMonth = new DateTime(year, month, 1);
        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
        var days = GetDaysInRange(firstDayOfMonth, lastDayOfMonth);
        return Ok(days);
    }

    private List<Day> GetDaysInRange(DateTime startDate, DateTime endDate)
    {
        // TODO Code to retrieve days from the database within the specified date range
        // ...
        return new List<Day>();
    }
}