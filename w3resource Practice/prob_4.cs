using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] ints = new int[size];

            Console.WriteLine("Input 3 elements in the array : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - " + i + " - ");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] ints1 = new int[size];
            Console.WriteLine("The elements stored in the first array are : ");
            for (int i=0; i<size; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("The elements stored in the second array are : ");
            for (int i = 0; i < size; i++)
            {
                ints1[i] = ints[i];
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(ints1[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
