using Microsoft.AspNetCore.Mvc;

namespace CaloryCalculator.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DayController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
}