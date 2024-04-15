﻿using Cw5.Database;
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
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = new MockDb().GetAnimalById(id);
        if (animal == null)
        {
            return NotFound();
        }
        
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
    
    
}