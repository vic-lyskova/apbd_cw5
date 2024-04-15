using Cw5.Models;

namespace Cw5.Database;

public class StaticData
{
    public static readonly List<Animal> Animals = new List<Animal>()
    {
        new Animal("Adam", "dog", 5.2, "brown"),
        new Animal("Lucky", "cat", 3.0, "multicolor"),
        new Animal("Popo", "parrot", 1.5, "red"),
        new Animal("Dave", "cat", 3.5, "orange"),
        new Animal("Mimi", "dog", 25.7, "white"),
        new Animal("Jack", "snake", 1.5, "green scales"),
        new Animal("Scout", "hamster", 0.9, "beige")
    };

    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit("2024-12-05", Animals[0], "visit 0, animal is great and will live a long and happy life", 100),
        new Visit("2023-10-10", Animals[5], "visit 1, animal is great and will live a long and happy life", 55.5),
        new Visit("2021-05-08", Animals[2], "visit 2, animal is great and will live a long and happy life", 30),
    };
}