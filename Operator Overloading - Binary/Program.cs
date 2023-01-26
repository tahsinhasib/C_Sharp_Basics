using System;

namespace ConsoleApp1
{
    class Complex
    {
        decimal x, y; 
        public Complex()
        { 

        }
        public Complex(decimal real, decimal imag)
        {
            x = real;
            y = imag;
        }
        public void ShowXY()
        {
            Console.WriteLine("The two values are :- \n Real value X = {0} Imaginary value Y = {1} \n", x, y);
        }
        public void show()
        {
            Console.WriteLine("Addition of complex numbers x(real) + i(imaginary)y is {0} + i{1}", x, y);
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex(); 
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y; 
            return temp;
        }
    }
    class MyClient
    {
        public static void Main()
        {
            Complex c1 = new Complex(10, 20);
            Console.WriteLine("\t \t Implementation of Binary operator Overloading!! \n ");
            Console.WriteLine("\t \t **************************************************");

            c1.ShowXY(); // displays 10 & 20

            Complex c2 = new Complex(20, 30);
            Console.WriteLine("Now passing two other values \n");
            c2.ShowXY(); // displays 20 & 30

            Complex c3 = new Complex();
            c3 = c1 + c2;

            Console.WriteLine("\t \t Overloading binary operator '+' to add two complex numbers \n");
            Console.WriteLine("\t \t 	");

            c3.show();
            
            Console.ReadKey();
        }
    }

}
