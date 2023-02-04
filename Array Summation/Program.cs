using System;

namespace ConsoleApp1
{
    public class funcexer5
    {
        public static int myfun(int[] arr1)
        {
            int tot = 0;
            for (int i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            return tot;
        }
        public static void Main()
        {
            int[] arr1 = new int[5];
            Console.Write("Input 5 elements in the array :\n");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("element - {0} : ", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("{0}", myfun(arr1));
            Console.ReadKey();
        }
    }
}

