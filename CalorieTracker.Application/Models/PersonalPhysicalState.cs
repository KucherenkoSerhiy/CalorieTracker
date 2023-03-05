using CalorieTracker.Application.Enums;

namespace CalorieTracker.Application.Models
{
    public class PersonalPhysicalState
    {
        public double WeightKg { get; set; }
        public double HeightCm { get; set; }
        public double AgeYears { get; set; }
        public Gender Gender { get; set; }
        public ActivityType CurrentActivity { get; set; }
    }
}