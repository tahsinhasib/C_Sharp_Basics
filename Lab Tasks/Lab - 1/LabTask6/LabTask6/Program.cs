﻿using System;


namespace LabTask6
{
	class Program
	{
		static void Main(string[] args)
		{
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            Console.ReadKey();
        }
	}
}
