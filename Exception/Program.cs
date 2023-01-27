using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                // To catch any exceptions which are likely to occur you use a try catch block.
                string result = "k";
				Console.WriteLine(Convert.ToInt32(result) + 10);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey();
        }
    }
}
