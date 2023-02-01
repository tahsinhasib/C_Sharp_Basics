using System;


namespace LabTask4
{
    // Create a Car class
    class Car
    {
        public string model; // Create a field
                             // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }
        static void Main(string[] args)
        {
            Car Ford = new Car(); // Create an object of the Car Class (this wi
            Console.WriteLine(Ford.model); // Print the value of model
            Console.ReadKey();
        }
    }
}
