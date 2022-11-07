using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 5, 6, 1, 2, 3, 2, 1, 0 };

            Console.WriteLine("number of Array are below");

            for (int i = 0; i < 9; i++) // some code which run infinite times
            {
                printf("[%d] : %d\n", i, numbers[0]);
            }

            List<int> duplicatedItems = new List<int>() { 1, 1, 2, 3, 3, 4 };

            var uniqueItems = duplicatedItems.Distinct();  //Print newly created collection to screen using for loop

            foreach (int item in duplicatedItems)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"our current number is: {i}");
            }

            //while           
            int i = 0;
            while (i <= 10)
            {
                i++;
                if (i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine($"{i} is a multiple of 3");
            }
        }
        private static void printf(string v1, int i, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
