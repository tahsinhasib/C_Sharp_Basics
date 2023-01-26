using System;

namespace ConsoleApp1
{
    class Shape
    {
        protected int width, height; 
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    //interface declarations
    public interface PaintCost 
    {
        int getCost(int area);
    }

    // Derived class inherits shape class & interface
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle(); 

            int area;
            Rect.setWidth(5); 
            Rect.setHeight(7); 
            area = Rect.getArea();

            Console.WriteLine("\t \t IMPLEMENTATION OF MULTIPLE INHERITANCE \n"); 
            Console.WriteLine("Painting Details:- \n");

            Console.WriteLine("Total area: {0}", Rect.getArea()); 
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
            Console.ReadKey();
        }
    }
}
