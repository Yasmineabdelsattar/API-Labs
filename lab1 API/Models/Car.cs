using lab1_API.Validation;
using System.Reflection;

namespace lab1_API.Models;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;

    [DateInPast]
    public DateTime ProductionDate { get; set; }

    public string Type { get; set; } = string.Empty;

    public Car(int id,
        string name,
        string model,
        DateTime productionDate)
    {
        Id = id;
        Name = name;
        Model = model;
        ProductionDate = productionDate;
    }

    private static List<Car> _cars = new List<Car>
    {
        new (1, "toyota", "Camry",new DateTime(1982, 3, 4)),
        new (2, "mercedes", "S-Class", new DateTime(1972, 7, 11)),
        new (3, "bmw", "wow", new DateTime(1964, 4, 17)),
        new (4, "kia", "sefia", new DateTime(1975, 5, 2)),
        new (5, "honda", "Civic", new DateTime(1994, 11, 4))
    };

    public static List<Car> GetCars() => _cars;
}

