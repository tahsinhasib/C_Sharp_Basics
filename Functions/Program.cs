using System;

namespace ConsoleApp2
{
    public class Program
    {
        // User defined function without return type  
        public void Show()  
        {
            Console.WriteLine("This is non parameterized function");
 
        }

        public static void Main(string[] args)
        {
            Program program = new Program();    // Creating Object  
            program.Show();                     // Calling Functio
            Console.ReadKey();
        }
    }
}
