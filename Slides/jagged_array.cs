using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[][] arr = new int[3][]
        {
            new int[]{1,2,3,4},
            new int[] {1,3,5},
            new int[] {4,5,6}
        };

        for(int i=0; i<arr.Length; i++)
        {
            for(int j=0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}