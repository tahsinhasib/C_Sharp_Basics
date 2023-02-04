using System;

namespace ConsoleApp1
{
    public class SumofInt
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.WriteLine("The summation is: " + sum);
            Console.ReadKey();
        }
    }
}
