using System;

public class Program
{
    enum level
    {
        low, medium, high
    }

    enum Months
    {
        January,
        Febuary
    }
    public static void Main(string[] args)
    {
        level l1 = level.low;
        Console.WriteLine(l1);

        Months m1 = Months.January;
        Console.WriteLine(m1);
    }
}