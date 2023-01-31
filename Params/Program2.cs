using System;

namespace ConsoleApp2
{
    //initializing the jagged array while declaration!
    public class Program2
    {
        /*In C#, params is a keyword which is used to specify a parameter that takes variable 
         * number of arguments. It is useful when we don't know the number of arguments prior. 
         * Only one params keyword is allowed and no additional parameter is permitted after 
         * params keyword in a function declaration.
         */

        
        public void Show(params object[] items)                 // Params Paramater  
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            Program2 program = new Program2(); // Creating Object  
            program.Show("Valorant", "Apex", 101, 20.50, "CSGO", 'A'); // Passing arguments of variable length
                                                                                   
            Console.ReadKey();
        }

    }
}
