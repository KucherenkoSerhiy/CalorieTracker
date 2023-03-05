namespace CalorieCalculator.Application.Models;

public class Exercise
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public double CaloriesPerHour { get; set; }
    public TimeSpan Duration { get; set; }
}