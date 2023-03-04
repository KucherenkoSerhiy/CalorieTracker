namespace CalorieCalculator.Application.Models
{
    public class Person
    {
        public Guid Id { get; }
        public PersonalPhysicalState PersonalPhysicalState { get; set; } = new ();
        public WeightGoal WeightGoal { get; set; }
        public double GoalKiloCalories { get; set; }
        
        public Person()
        {
            Id = Guid.NewGuid();
        }
    }
}