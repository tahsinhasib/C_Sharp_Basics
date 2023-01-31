using System;

namespace ConsoleApp2
{
    public class Employee
    {
        public int id;
        public String name;
        public float salary;
        public Employee(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Dog", 890000f);
            Employee e2 = new Employee(102, "Cat", 490000f);
            e1.display();
            e2.display();

            Console.ReadKey();
        }
    }
}
