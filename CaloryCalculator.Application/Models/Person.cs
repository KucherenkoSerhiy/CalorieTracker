namespace CaloryCalculator.Application.Models
{
    public class Person
    {
        public int Id { get; set; }
        public List<Day> Days { get; set; } = new();
    }
}