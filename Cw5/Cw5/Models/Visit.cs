namespace Cw5.Models;

public class Visit
{
    public string Date { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Visit(string date, Animal animal, string description, double price)
    {
        Date = date;
        Animal = animal;
        Description = description;
        Price = price;
    }
}