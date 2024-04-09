namespace Cw5.EndPoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints (this WebApplication app)
    {
        //Minimal API
        app.MapGet("/animals",  () =>
        {
            // 200 - OK
            return Results.Ok();
        });
        app.MapGet("/animals/{id}",  (int id) =>
        {
    
            return Results.Ok(id);
        });

        app.MapPost("/animals", () =>
        {
            // 201 - Created
            return Results.Created();
        });
    }
}