namespace CalorieCalculator.Application.Models
{
    public class Day
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Date { get; set; }
        public double TotalCaloriesConsumed { get; set; }
        public double TotalCaloriesBurned { get; set; }
        public List<Product> ConsumedProducts { get; set; } = new();
        public List<Exercise> Performed { get; set; } = new();

        public void AddExercise(Exercise exercise)
        {
            TotalCaloriesBurned += exercise.CaloriesPerHour * exercise.Duration.TotalHours;
            var existingExercise = Performed.FirstOrDefault(e => e.Name == exercise.Name);
            if (existingExercise != null)
            {
                existingExercise.Duration += exercise.Duration;
            }
            else
            {
                Performed.Add(exercise);
            }
        }

        public void AddConsumedProduct(Product product)
        {
            TotalCaloriesConsumed += product.Calories;
            ConsumedProducts.Add(product);
        }
    }
}