using System;
using System.Collections.Generic;

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();

            cars.Add("Toyota");
            cars.Add("Hunda");
            cars.Add("Ford");
            cars.Add("Mazda");

            Console.WriteLine("All elements of cars string is:\n\n");
            Console.WriteLine(cars[3]);
                    
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);
            numbers.Add(9);

            Console.WriteLine("Enter a number\n");
            int number = Convert.ToInt32(Console.ReadLine());// Convert code to an integer

            if (number > 9) //if not a whole number input give an error
            {
                Console.WriteLine("the number was out of range");
            }
        }
    }
}
