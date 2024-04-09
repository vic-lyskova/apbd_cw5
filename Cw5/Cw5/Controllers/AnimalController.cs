using Cw5.Database;
using Microsoft.AspNetCore.Mvc;

namespace Cw5.Controllers;

[ApiController]
[Route("/animals-controller")]
// [Route("[controller]")
public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}