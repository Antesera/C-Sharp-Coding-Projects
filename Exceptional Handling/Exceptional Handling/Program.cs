using System;
using System.Collections.Generic;

namespace Exceptional_Handling
{
    class Program
    {
        private static int num0;
        private static int num1;

        static void Main(string[] args)
        {
            try
            {
                List<int> listnum = new List<int> {6, 8, 10, 40};              
                
                Console.WriteLine("please enter the first number ");
                num0 = Convert.ToInt32(Console.ReadLine());

                foreach ( int i in listnum )
                {
                    Console.WriteLine(i/num0);
                }          
            }
             catch(DivideByZeroException) //Division by zero attempt
            {
                Console.WriteLine("Don't divide by Zero");
            }
            catch(FormatException)//Catch block
            {
                Console.WriteLine("Enter value number");
            }
            finally 
            {
                Console.WriteLine("program Excuted");
            }

        }
    }
}
