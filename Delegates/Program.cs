using System;
using System.Threading;

namespace ConsoleApp1
{
    delegate int NumberChange(int n); 
    class ex5
    {
        static int num = 10;
        public static int addnum(int p)
        {
            num += p; 
            return num;
        }
        public static int multnum(int q)
        {
            num *= q;
            return num;
        }
        public static int getnum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t Implementation of Delegates!!!");
            Console.WriteLine("\t \t********************************\n");

            NumberChange nc1 = new NumberChange(addnum);
            NumberChange nc2 = new NumberChange(multnum);

            nc1(25);
            Console.WriteLine("Result of addition is {0}\n", getnum());
            nc2(5);
            Console.WriteLine("Result of multiplication is {0}", getnum()); 
            
            Console.ReadKey();
        }

    }

}
