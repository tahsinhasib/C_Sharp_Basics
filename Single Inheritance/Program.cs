using System;

namespace ConsoleApp1
{
    class Rectangle
    {
        protected double length, width;

        public void getdata()
        {
            Console.WriteLine("Enter the length and width of the rectangle in double format: "); 
            length = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    //new class
    class Tabletop : Rectangle
    {
        private double cost;

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70; return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }

    // main method containing class doesnt have to be the same as the name of the c sharp file
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(); t.getdata();
            t.Display(); Console.ReadKey();
        }
    }

}
