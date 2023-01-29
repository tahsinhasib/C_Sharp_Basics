﻿using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* The C# goto statement is also known jump statement. It is used to transfer control 
               to the other part of the program. It unconditionally jumps to the specified label.
               It can be used to transfer control from deeply nested loop or switch case label.
               Currently, it is avoided to use goto statement in C# because it makes the program complex.
            */

        ineligible:
            Console.WriteLine("You are not eligible to vote!");

            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }
            Console.ReadKey();
        }
    }
}
