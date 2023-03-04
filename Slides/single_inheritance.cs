using System;

public class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal Constructor!");
    }
    public void Move()
    {
        Console.WriteLine("I am moving!");
    }
}


public class Cat : Animal
{
    public Cat() : base()
    {
        Console.WriteLine("Cat Constructor!");
    }
    public void Climb()
    {
        //base.Move();
        Console.WriteLine("Cat Climbing!");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Cat c = new Cat();
        Console.WriteLine();
        c.Climb();
        Console.ReadKey();
    }
}