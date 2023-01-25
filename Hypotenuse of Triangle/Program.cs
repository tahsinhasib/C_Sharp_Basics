using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Length of sides.
            double s1 = 4.0; 
            double s2 = 5.0;

            // dynamically initialize hypotenuse
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Hypotenuse of triangle with sides " + s1 + " by " + s2 + " is ");

            //format to display using 3 decimal values
            Console.WriteLine("{0:#.###}.", hypot);                        
            Console.ReadKey();
        }
    }
}
