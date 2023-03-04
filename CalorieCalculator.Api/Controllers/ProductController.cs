using CalorieCalculator.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalorieCalculator.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IDayService dayService;

    public ProductController(IDayService dayService)
    {
        this.dayService = dayService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AddConsumedProduct([FromBody] Product? product)
    {
        if (product == null) return BadRequest("Product cannot be null.");
        
        var today = await dayService.GetOrCreateDayAsync(DateTime.Today);
        today.AddConsumedProduct(product);
        await dayService.SaveDayAsync(today);
        return Ok();
    }
}
