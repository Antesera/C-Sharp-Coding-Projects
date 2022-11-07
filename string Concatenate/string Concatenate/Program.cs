using System;
using System.Linq;
using System.Collections.Generic;

namespace string_Concatenate
{
    class Program
    {
        private static IEnumerable<int> uniqueNumbers;

        private static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 5, 6, 1, 2, 3, 2, 1, 0 };

            Console.WriteLine("number of Array are below");
            
            //foreach
            foreach (int num  in numbers)
            {
                //for
                for (int i = 0; i < 9; i--)
                {
                    Console.Write("value : {0} ", i);
                }
                
            }
               for (int i = 0;  i < 9; i++) // some code which run infinite times
               {
                printf("[%d] : %d\n", i, numbers[0]);
               }
            
            //while
            int num01 = 0;
             while (num01 <= 10)
            {
                Console.WriteLine("loop nr " + num01);
                num01++;
            }
        
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
