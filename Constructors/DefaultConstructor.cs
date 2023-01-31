using System;

namespace ConsoleApp2
{
    
    public class DefaultConstructor
    {
        public DefaultConstructor()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            DefaultConstructor e1 = new DefaultConstructor();
            DefaultConstructor e2 = new DefaultConstructor();
            Console.ReadKey();
        }
    }
}
