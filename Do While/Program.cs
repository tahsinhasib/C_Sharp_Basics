using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            Console.ReadKey();
        }
    }
}
