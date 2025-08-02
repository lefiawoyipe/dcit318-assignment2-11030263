using System;

// Interface
interface IMovable
{
    void Move();
}

// Car implements IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle implements IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        IMovable[] movers = { new Car(), new Bicycle() };

        foreach (var m in movers)
        {
            m.Move();
        }
    }
}

