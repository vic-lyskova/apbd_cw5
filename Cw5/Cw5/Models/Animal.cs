﻿namespace Cw5.Models;

public class Animal
{
    private static int _id;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Mass { get; set; }
    public string FurColor { get; set; }

    public Animal(string name, string category, double mass, string furColor)
    {
        Id = ++_id;
        Name = name;
        Category = category;
        Mass = mass;
        FurColor = furColor;
    }
}