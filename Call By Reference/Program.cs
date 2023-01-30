using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
C# provides a ref keyword to pass argument as reference-type. It passes reference of arguments to the function 
rather than copy of original value. The changes in passed values are permanent and modify the original variable value.
*/


namespace ConsoleApp2
{
    public class Program
    {
        // User defined function  
        public void Show(ref int val)
        {
            val *= val;                                                     // Manipulating value  
            Console.WriteLine("Value inside the show function " + val); 
        }
         
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();  
            Console.WriteLine("Value before calling the function " + val);

            program.Show(ref val);        
            Console.WriteLine("Value after calling the function " + val);

            Console.ReadKey();
        }
    }
}
