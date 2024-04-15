using Cw5.Models;

namespace Cw5.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animals.Add(new Animal("Dave", "cat", 3.5, "orange"));
        Animals.Add(new Animal("Mimi", "dog", 25.7, "white"));
        Animals.Add(new Animal("Jack", "snake", 1.5, "green scales"));
        Animals.Add(new Animal("Scout", "hamster", 0.9, "beige"));
    }
}