﻿using Cw5.Database;
using Cw5.Models;
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
            return NotFound("Animal with id " + id + " not found");
        }
        
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        StaticData.Animals.Add(animal);
        return Created();
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToUpdate = new MockDb().GetAnimalById(id);
        if (animalToUpdate == null)
        {
            return NotFound("Animal with id " + id + " not found");
        }

        StaticData.Animals.Remove(animalToUpdate);
        StaticData.Animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id::int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = new MockDb().GetAnimalById(id);
        if (animal == null)
        {
            return NoContent();
        }

        StaticData.Animals.Remove(animal);
        return NoContent();
    }
}