using System;
using System.Collections.Generic;

namespace Exceptional_Handling_C_Sharpe
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                List<int> listnum = new List<int>();
                listnum.Add(num0);
                listnum.Add(num1);

                Console.WriteLine("please enter the number 0:");
                int num0 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter the number 1:");
                int num1 = Convert.ToInt32(Console.ReadLine());
        
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(i);
                }

                int quotient = (num0 / num1);
                Console.WriteLine("Division of num0 and num0 is = " + quotient);

            }
            catch (DivideByZeroException ex) //Division by Zero Attempted
            {
                Console.WriteLine("Don't divide by Zero");
            }
            catch (FormatException ex) //catch block
            {
                Console.WriteLine("Enter value number");
            }
            finally
            {
                Console.WriteLine("program Excuted");
            }
            Console.ReadLine();
        }
    }
}
