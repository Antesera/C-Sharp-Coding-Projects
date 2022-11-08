using System;
using System.Collections.Generic;

namespace Exceptional_Handling
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                List<int> listnum = new List<int> ();

                int x, y, z;
                Console.WriteLine("please enter the first number ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter the second number ");
                y = Convert.ToInt32(Console.ReadLine());
                foreach ( int i in listnum )
                {
                    z = x / y;
                    Console.WriteLine(z);
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
