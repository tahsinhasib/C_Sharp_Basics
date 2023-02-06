using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array :");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] ints = new int[size];

            Console.WriteLine("Input 3 elements in the array :");
            for (int i=0; i<size; i++)
            {
                Console.Write("element - " + i + " - ");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += ints[i];
            }
            Console.Write("Sum of all elements stored in the array is : " + sum);
            Console.ReadKey();
        }
    }
}
