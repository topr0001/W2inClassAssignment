namespace W2InClassAssignment;

public class Car
{
    public Engine Engine { get; set; }
    public string Model { get; set; }
    

    public Car(Engine engine, string model)
    {
        Engine = engine;
        Model = model;
    }

    public void Describe()
    {
        Console.WriteLine($"Engine Horsepower: {Engine.HorsePower}");
        Console.WriteLine($"Model: {Model}");
    }
}