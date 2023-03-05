using CalorieCalculator.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace CalorieCalculator.Infrastructure.Context;

public class DataContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Day> Days { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Exercise> Exercises { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the Person entity
        modelBuilder.Entity<Person>(person =>
        {
            person.HasKey(p => p.Id);

            person.OwnsOne(p => p.PersonalPhysicalState, state =>
            {
                state.Property(s => s.WeightKg).IsRequired();
                state.Property(s => s.HeightCm).IsRequired();
                state.Property(s => s.AgeYears).IsRequired();
                state.Property(s => s.Gender).IsRequired();
                state.Property(s => s.CurrentActivity).IsRequired();
            });

            person.HasMany(p => p.Days)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure the Day entity
        modelBuilder.Entity<Day>(day =>
        {
            day.HasKey(d => d.Id);

            day.Property(d => d.Date)
                .IsRequired();

            day.Property(d => d.TotalCaloriesConsumed)
                .IsRequired();

            day.Property(d => d.TotalCaloriesBurned)
                .IsRequired();

            day.HasMany(d => d.Consumed)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            day.HasMany(d => d.Performed)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure the Product entity
        modelBuilder.Entity<Product>(product =>
        {
            product.HasKey(p => p.Id);

            product.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            product.Property(p => p.Calories)
                .IsRequired();

            product.Property(p => p.ServingSizeGrams)
                .IsRequired();
        });

        // Configure the Exercise entity
        modelBuilder.Entity<Exercise>(exercise =>
        {
            exercise.HasKey(e => e.Id);

            exercise.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

            exercise.Property(e => e.CaloriesPerHour)
                .IsRequired();

            exercise.Property(e => e.Duration)
                .IsRequired();
        });
    }
}

