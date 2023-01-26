using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] laptop = new string[] { "Dell", "Lenovo", "MacBook" };

            Console.Write("Displaying all the laptops: ");
            for(int i=0; i<laptop.Length; i++)
            {
                Console.Write(laptop[i] + " ");
            }
            Console.WriteLine("\n");

            int[] num = new int[] { 4, 5, 6, 7, };

            Console.Write("Displaying all numbers: ");
            for(int i=0; i<num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
