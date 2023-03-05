using System;
using System.Collections.Generic;
using System.Linq;

namespace CalorieTracker.Application.Models
{
    public class Day
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Date { get; set; }
        public double TotalCaloriesConsumed { get; set; }
        public double TotalCaloriesBurned { get; set; }
        public List<Product> ConsumedProducts { get; set; } = new();
        public List<Exercise> PerformedExercises { get; set; } = new();

        public void AddExercise(Exercise exercise)
        {
            TotalCaloriesBurned += exercise.CaloriesPerHour * exercise.Duration.TotalHours;
            var existingExercise = PerformedExercises.FirstOrDefault(e => e.Name == exercise.Name);
            if (existingExercise != null)
            {
                existingExercise.Duration += exercise.Duration;
            }
            else
            {
                PerformedExercises.Add(exercise);
            }
        }

        public void AddConsumedProduct(Product product)
        {
            TotalCaloriesConsumed += product.Calories;
            ConsumedProducts.Add(product);
        }
    }
}