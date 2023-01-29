using System;

namespace ConsoleApp2
{
    public class returnType
    {
        // User defined function  
        public string Show(string message)
        {
            Console.WriteLine("Inside Show Function");
            return message;
        }

        public static void Main(string[] args)
        {
            returnType program = new returnType();
            string message = program.Show("Tahsin");
            Console.WriteLine("Hello " + message);
            Console.ReadKey();
        }
    }
}
