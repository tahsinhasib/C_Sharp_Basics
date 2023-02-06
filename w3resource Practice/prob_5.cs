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

            Console.WriteLine();
            int count = 0;

            for(int i=0; i < ints.Length; i++)
            {
                for(int j=0; j<ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("element " + ints[i] + " is found " + count + " times!");
                count = 0;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
