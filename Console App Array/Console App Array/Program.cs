using System;
using System.Collections.Generic;

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Cars = new List<string>();

            Cars.Add("Toyota");
            Cars.Add("Hunda");
            Cars.Add("Ford");
            
            //string[] cars = { "Toyota", "Hunda", "Ford", "Mazda" };

            Console.WriteLine("All elements of cards string is:\n\n");
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(Cars[2]);

            Console.WriteLine(array1[3]);
        }
    }
}
