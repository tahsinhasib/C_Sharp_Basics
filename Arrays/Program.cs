using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example
            string[] laptop = new string[] { "Dell", "Lenovo", "MacBook" };

            Console.Write("\nDisplaying all the laptops: ");
            for(int i=0; i<laptop.Length; i++)
            {
                Console.Write(laptop[i] + " ");
            }
            Console.WriteLine("\n");

            // example
            int[] num = new int[] { 4, 5, 6, 7, };

            Console.Write("\nDisplaying all numbers: ");
            for(int i=0; i<num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            // example
            Console.WriteLine("\nArray example: ");
            int[] array = { 4, 5, 6 };
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }


            //for each loop
            Console.Write("\nFor each loop: ");
            foreach(int list in array)
            {
                Console.Write(list + " ");
            }
            
            Console.ReadKey();
        }
    }
}
