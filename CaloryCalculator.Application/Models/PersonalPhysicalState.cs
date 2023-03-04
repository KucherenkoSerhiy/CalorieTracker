using CaloryCalculator.Application.Enums;

namespace CaloryCalculator.Application.Models;

public class PersonalPhysicalState
{
    public double WeightKg { get; set; }
    public double HeightCm { get; set; }
    public double AgeYears { get; set; }
    public ActivityType ActivityType { get; set; }
}