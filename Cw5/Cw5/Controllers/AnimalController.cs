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
        return Ok();
    }

    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}