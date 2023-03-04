using Microsoft.AspNetCore.Mvc;

namespace CalorieCalculator.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DayController : ControllerBase
{
    /*
    ### View Total Calorie Balance
    **AS** a Person <br/>
    view the total calories consumed vs. burned
     */
    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
}