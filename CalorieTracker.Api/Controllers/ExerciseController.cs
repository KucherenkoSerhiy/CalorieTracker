using System;
using System.Threading.Tasks;
using CalorieTracker.Application.Models;
using CalorieTracker.Application.Services.DayService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalorieTracker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly IDayService dayService;

        public ExerciseController(IDayService dayService)
        {
            this.dayService = dayService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddExercise([FromBody] Exercise? exercise)
        {
            if (exercise == null) return BadRequest("Product cannot be null.");
        
            var today = await dayService.GetOrCreateDayAsync(DateTime.Today);
            today.AddExercise(exercise);
            await dayService.SaveDayAsync(today);
            return Ok();
        }
    }
}