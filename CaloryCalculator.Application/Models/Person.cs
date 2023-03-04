namespace CaloryCalculator.Application.Models
{
    public class Person
    {
        public int Id { get; set; }
        public IEnumerable<Day> Days { get; set; }
    }
}