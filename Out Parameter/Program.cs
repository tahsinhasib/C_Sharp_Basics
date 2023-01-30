using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*C# provides out keyword to pass arguments as out-type. It is like reference-type, 
     * except that it does not require variable to initialize before passing. We must use 
     * out keyword to pass argument as out-type. It is useful when we want a function to 
     * return multiple values.
     */

    public class Program
    {
        public void Show(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; 
        }
        
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();  
            Console.WriteLine("Value before passing out variable " + val);

            program.Show(out val); // Passing out argument  
            Console.WriteLine("Value after recieving the out variable " + val);

            Console.ReadKey();
        }
    }
}
