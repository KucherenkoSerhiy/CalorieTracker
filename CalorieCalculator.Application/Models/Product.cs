namespace CalorieCalculator.Application.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Calories { get; set; }
    public double ServingSizeGrams { get; set; }
}