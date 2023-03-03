using System;
class Ex2
{
    class Student
    {
        public int[] studid = new int[5];
        public int[] day = new int[5];
        public int[] month = new int[5];
        public int[] year = new int[5];
        public string[] name = new string[5];
        public string[] cname = new string[5];
        public void details()
        {
            Console.WriteLine("Implementation of Classes and Objects ");
            Console.WriteLine("**************************************");
            Console.WriteLine("Enter students details and you can view those details");
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            s.details();
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter Student Id:");
                s.studid[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student name : ");
                s.name[i] = Console.ReadLine();
                Console.Write("Enter Course name : ");
                s.cname[i] = Console.ReadLine();
                Console.Write("Enter date of birth\n Enter day(1-31):");
                s.day[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter month(1-12):");
                s.month[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter year:");
                s.year[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\nStudent's List\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\nStudent ID : " + s.studid[i]);
                Console.WriteLine("\nStudent name : " + s.name[i]);
                Console.WriteLine("\nCourse name : " + s.cname[i]);
                Console.WriteLine("\nDate of birth(dd-mm-yy) : " + s.day[i] + "-" + s.month[i] + "-" +
                s.year[i]);
                Console.ReadKey();
            }
        }
    }
}
