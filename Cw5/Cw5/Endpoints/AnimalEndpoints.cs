using Cw5.Database;
using Cw5.Models;

namespace Cw5.EndPoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints (this WebApplication app)
    {
        //Minimal API
        app.MapGet("/animals",  () =>
        {
            // 200 - OK
            var animals = StaticData.Animals;
            
            return Results.Ok(animals);
        });
        app.MapGet("/animals/{id}",  (int id) =>
        {

            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            // 201 - Created
            return Results.Created("", animal);
        });
    }
}