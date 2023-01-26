using System;

namespace ConsoleApp1
{
    public class Person
    {
        protected string regno, name; 
        public void get()
        {
            Console.WriteLine("Multilevel Inheritance!");
            Console.WriteLine("Enter the register number and name of a student :-"); 
            regno = Console.ReadLine();
            name = Console.ReadLine();
        }

        public virtual void display()
        {

            Console.WriteLine("Student register number - {0} and name is {1}", regno, name);
            Console.ReadLine();
        }

    }
    class Student : Person
    {
        public string Classincharge = "Mr.ABC"; 
        public override void display()
        {
            base.display();
            Console.WriteLine("Class incharge of the Student is: {0}", Classincharge);
        }
    }
    class Details : Student
    {
        private string StudentAddress = "BIHER Hostel, Chennai";
        public void display()
        {
            Console.WriteLine("Student Address: {0}", StudentAddress);

        }
    }
    class TestClass
    {
        public static void Main()
        {
            Student s = new Student();
            s.get();
            s.display();
            Details d = new Details();
            d.display();
            Console.ReadKey();
        }
    }


}
