using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size]; 

            for(int i=0; i<size; i++)
            {
                Console.Write("Enter element - "+ (i+1) + " - ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();


            Console.Write("Elements in array are: ");
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
