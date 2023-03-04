﻿namespace CaloryCalculator.Application.Models
{
    public class Day
    {
        public DateTime Date { get; set; }
        public double TotalCaloriesConsumed { get; set; }
        public double TotalCaloriesBurned { get; set; }
        public List<Product> Consumed { get; set; } = new List<Product>();
        public List<Exercise> Performed { get; set; } = new List<Exercise>();
    }
}