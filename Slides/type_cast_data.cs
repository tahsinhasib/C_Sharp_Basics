namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type casting example!\n");

            float a = 5454.15F;

            Console.WriteLine("Float: {0}", a);       //correct and display
            Console.WriteLine("Float: ", a);          //correct but no display
            Console.WriteLine("Float: " + a);         //correct and display

            //float to double
            float num1 = 4565.145F;
            float num2 = 514.451F;
            double num12 = num1 + num2;

            //implicit
            Console.WriteLine("\nFloat to Double: " + num12);

            //explicit
            float temp;
            temp = (float)num12;
            Console.WriteLine("\nDouble to Float: " + num12);

            //implicit
            long num3 = 45554;
            long num4 = 4565;
            float num34 = num3 + num4;
            Console.WriteLine("\nLong to Float: " + num34);


            //explicit
            long temp2;
            temp2 = (long)num34;
            Console.WriteLine("\nFloat to Long: " + num34);

            //explicit
            int x = (int)num34;
            Console.WriteLine("\nFloat to Int: " + num34);



            Console.ReadKey();
        }
    }
}