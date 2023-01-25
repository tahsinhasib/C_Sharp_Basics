using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str; /* Declares a string of size 100 */ 
            int length = 0;

            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("\n"); 
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                length += 1;
            }
            Console.Write("Length of the string is : {0}\n\n", length); 
            Console.ReadKey();
        }
    }
}
