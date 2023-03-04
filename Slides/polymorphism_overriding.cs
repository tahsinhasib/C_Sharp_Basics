using System;

public class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Moving!");
    }
}

public class Rhino : Animal
{
    public override void Move()
    {
        Console.WriteLine("Charging!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Rhino r = new Rhino();
        r.Move();
        Console.ReadKey();
    }
}