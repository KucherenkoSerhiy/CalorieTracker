using CalorieCalculator.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalorieCalculator.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly IPersonService personService;
    private readonly IDayService dayService;

    public PersonController(IPersonService personService, IDayService dayService)
    {
        this.personService = personService;
        this.dayService = dayService;
    }

    [HttpGet("last-7-days")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<Person>> GetLast7Days()
    {
        var person = await personService.GetPersonAsync();
        person.Days = await dayService.GetLastNDays(7);
        return Ok(person);
    }

    [HttpGet("last-30-days")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<Person>> GetLast30Days()
    {
        var person = await personService.GetPersonAsync();
        person.Days = await dayService.GetLastNDays(30);
        return Ok(person);
    }

    [HttpGet("month")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<Person>> GetMonth(DateTime month)
    {
        var person = await personService.GetPersonAsync();
        person.Days = await dayService.GetMonth(month);
        return Ok(person);
    }
}