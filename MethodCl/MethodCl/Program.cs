using System;

namespace MethodCl
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodClass methodClass = new MethodClass();


            
            Console.WriteLine("please type the numbers");
            int X = Convert.ToInt32(Console.ReadLine());
            int y = 10;
            int Z;
            methodClass.OutPut(X);
            methodClass.OutPut(X, y, out Z);
            Console.ReadLine();
        }
    }
}
 