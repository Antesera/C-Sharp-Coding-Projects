using System;
                                       
namespace List__of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] cars = { "Toyota", "Hunda", "Ford", "Mazda" };
              
            Console.WriteLine("All the element of cars string is:\n\n");
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };   //array1 =  {1, 3, 5, 7, 9}; is Error
            Console.WriteLine(cars[0]);

            Console.WriteLine(array1[3]);
        }
    }
}

     