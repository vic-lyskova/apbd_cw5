using Cw5.Database;
using Cw5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw5.Controllers;

[ApiController]
[Route("/visits-controller")]
public class VisitController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetVisitsOfAnimal(int id)
    {
        var visits = new MockDb().GetVisitsOfAnimal(id);
        if (visits == null)
        {
            return NotFound("No visits in the system for animal with id " + id);
        }

        return Ok(visits);
    }

    [HttpPost]
    public IActionResult AddVisit(string date, int id, string description, double price)
    {
        var animal = new MockDb().GetAnimalById(id);
        if (animal == null)
        {
            return NotFound("Animal with " + id + " not in the system");
        }

        var visit = new Visit(date, animal, description, price);
        StaticData.Visits.Add(visit);
        return Created();
    }
}