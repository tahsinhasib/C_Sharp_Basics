using System;

namespace ConsoleApp2
{
    public class nonVoid
    {
        // User defined function without return type  
        public void Show(string message)
        {
            Console.WriteLine("Hello " + message);
            // No return statement  
        }

        public static void Main(string[] args)
        {
            nonVoid program = new nonVoid();    // Creating Object  
            program.Show("Disha");              // Calling Function                    
            Console.ReadKey();
        }
    }
}
