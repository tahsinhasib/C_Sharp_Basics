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

    public class multiOut
    {
        public void Show(out int a, out int b) // Out parameter  
        {
            int square = 5;
            a = square;
            b = square;
  
            a *= a;
            b *= b;
        }
          
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            multiOut program = new multiOut(); // Creating Object  
            Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
            program.Show(out val1, out val2); // Passing out argument  
            Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);

            Console.ReadKey();
        }
    }
}
