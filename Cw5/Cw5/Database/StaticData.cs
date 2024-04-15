using Cw5.Models;

namespace Cw5.Database;

public class StaticData
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal("Adam", "dog", 5.2, "brown"),
        new Animal("Lucky", "cat", 3.0, "multicolor"),
        new Animal("Popo", "parrot", 1.5, "red"),
    };
}