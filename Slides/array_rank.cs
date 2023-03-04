using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[2, 2];
        Console.WriteLine("The array has " + arr.Rank + " dimensions!");
        Console.ReadKey();
    }
}