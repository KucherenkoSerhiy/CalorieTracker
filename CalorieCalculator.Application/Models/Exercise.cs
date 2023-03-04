namespace CalorieCalculator.Application.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CaloriesPerHour { get; set; }
        public TimeSpan Duration { get; set; }
    }
}