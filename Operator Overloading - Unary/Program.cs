using System;

namespace ConsoleApp1
{
    class Negate
    {
        int x, y, z;
        public Negate(int a, int b, int c)
        {
            x = a; y = b; z = c;
        }
        void display()
        {
            Console.WriteLine("X={0},y={1},z={2}", x, y, z);
        }

        public static Negate operator -(Negate c)
        {
            c.x = -c.x;
            c.y = -c.y;
            c.z = -c.z; 
            return c;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\t \t Implementation of Unary operator Overloading!! \n ");
            Console.WriteLine("\t \t ************************************************");

            Negate p = new Negate(5, -6, 4);
            p.display();

            Negate p1 = new Negate(5, -6, 4); p1 = -p;
            Console.WriteLine("\nNegation is applied to all the values!!\n");
            p1.display();

            Console.ReadKey();
        }
    }
}
