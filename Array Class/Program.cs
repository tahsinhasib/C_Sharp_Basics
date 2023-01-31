﻿using System;

namespace ConsoleApp2
{
    /*C# provides an Array class to deal with array related operations. It provides methods for creating, 
    manipulating, searching, and sorting elements of an array. This class works as the base class for all 
    arrays in the .NET programming environment.
    */
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            // Creating an empty array  
            int[] arr2 = new int[6];

            // Displaying length of array  
            Console.WriteLine("length of first array: " + arr.Length);

            // Sorting array  
            Array.Sort(arr);
            Console.Write("First array elements: ");

            // Displaying sorted array  
            PrintArray(arr);

            // Finding index of an array element  
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));

            // Coping first array to empty array  
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("Second array elements: ");

            // Displaying second array  
            PrintArray(arr2);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(arr);
        }
         
        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
            Console.ReadKey();
        }

    }
}
