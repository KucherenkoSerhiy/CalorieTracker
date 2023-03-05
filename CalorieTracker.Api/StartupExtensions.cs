using CalorieTracker.Application.Repositories;
using CalorieTracker.Application.Services.DayService;
using CalorieTracker.Application.Services.PersonService;
using CalorieTracker.Infrastructure.Context;
using CalorieTracker.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Api
{
    public static class StartupExtensions
    {
        public static void RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IDayService, DayService>();
            builder.Services.AddScoped<IPersonService, PersonService>();

            builder.Services.AddScoped<IDayRepository, DayRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
        }
    
        public static void Configure(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();
        }
    }
}