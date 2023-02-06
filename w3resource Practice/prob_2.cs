using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ints = new int[n];

            Console.WriteLine("Input 3 number of elements in the array :");
            for(int i=0; i<n; i++)
            {
                Console.Write("element - " + i + " - ");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("The values store into the array in reverse are : ");
            for(int i=n-1; i>=0; i--)
            {
                Console.Write(ints[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
