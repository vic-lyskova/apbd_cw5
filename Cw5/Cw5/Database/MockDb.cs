using Cw5.Models;

namespace Cw5.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();

    public MockDb()
    {
        Animals.AddRange(StaticData.Animals);
        Visits.AddRange(StaticData.Visits);
    }

    public Animal? GetAnimalById(int id)
    {
        foreach (var animal in Animals)
        {
            if (animal.Id == id)
            {
                return animal;
            }
        }

        return null;
    }
    
    public List<Visit>? GetVisitsOfAnimal(int id)
    {
        var visits = Visits.FindAll(v => v.Animal.Id == id);

        if (visits.Count == 0)
        {
            return null;
        }
        return visits;
    }
}