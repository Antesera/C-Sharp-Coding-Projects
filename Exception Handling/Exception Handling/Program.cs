using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("enter value of a");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter value of b");
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division of a by b is = " + c);
            }
             catch (DivideByZeroException ex) //Division by Zero Attempted
            {
                Console.WriteLine("ex.Message");
            }
            catch (FormatException ex) //catch block
            {
                Console.WriteLine("ex.Message");
            }
            finally
            {
                Console.WriteLine("program Excuted");
            }
            Console.ReadLine();
        }
    }
}
