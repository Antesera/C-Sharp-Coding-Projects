using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List[] numbint = new int[4];
                numArray[0] = 8;
                numArray[1] = 4;
                numArray[2] = 2;
                numArray[3] = 1;
                           
                numArray[2] = numArray[0] / numArray[1];
                Console.WriteLine("Division of numArray[0] / numArray[1] is = " + numArray[2]);
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
