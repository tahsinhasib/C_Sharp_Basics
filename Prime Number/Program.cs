using System;

namespace ConsoleApp1
{
    public class funcexer9
    {
        public static bool chkprime(int num)
        {
            //int k = 0;
            for (int i = 2; i < num; i++)
            {
                //k++;
                //Console.WriteLine("Execution number " + k);
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main()
        {
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
            Console.ReadKey();
        }
    }
}