﻿using System;
using System.Collections.Generic;
using System.Linq;
using CalorieTracker.Application.Enums;

namespace CalorieTracker.Application.Models
{
    public class Person
    {
        public Guid Id { get; } = Guid.NewGuid();
        public PersonalPhysicalState PersonalPhysicalState { get; set; } = new();
        public WeightGoal WeightGoal { get; set; }
        public double GoalKiloCalories { get; set; }

        public List<Day> Days { get; set; } = new();
        public double TotalCaloriesConsumed => Days.Sum(x => x.TotalCaloriesConsumed);
        public double TotalCaloriesBurned => Days.Sum(x => x.TotalCaloriesBurned);
    }
}