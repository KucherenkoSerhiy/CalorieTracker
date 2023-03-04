namespace CalorieCalculator.Application.Models
{
    public class Person
    {
        private readonly PersonalPhysicalState personalPhysicalState = new ();
        public int Id { get; set; }
        public List<Day> Days { get; set; } = new();
    }
}