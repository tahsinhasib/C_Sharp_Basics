using System;

namespace ConsoleApp2
{
    public class MultiArray
    {
        /* The multidimensional array is also known as rectangular arrays in C#. 
         * It can be two dimensional or three dimensional. The data is stored in 
         * tabular form (row * column) which is also known as matrix.
         */

        public static void Main(string[] args)
        {
            Console.WriteLine("First approach!\n");
            int[,] arr = new int[3, 3];             //declaration of 2D array  
            arr[0, 1] = 10;                         //initialization  
            arr[1, 2] = 20;
            arr[2, 0] = 30;

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();                //new line at each row  
            }


            Console.WriteLine("\nAnother approach!\n");
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };        //declaration and initialization  

            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
