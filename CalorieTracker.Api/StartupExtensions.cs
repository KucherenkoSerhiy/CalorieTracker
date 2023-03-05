using CalorieTracker.Application.Repositories;
using CalorieTracker.Application.Services.DayService;
using CalorieTracker.Application.Services.PersonService;
using CalorieTracker.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CalorieTracker.Api
{
    public static class StartupExtensions
    {
        public static void RegisterServices(this WebApplicationBuilder builder)
        {
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

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}