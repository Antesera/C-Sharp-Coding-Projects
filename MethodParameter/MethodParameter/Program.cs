using System;

namespace MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            parameter1 MyObject = new parameter1();
            //MyObject.num1 = 4;
           // MyObject.num2 = 8;
           // MyObject.MethodParameter();
            Console.WriteLine(MyObject.MethodParameter(5, 9, 11));
            Console.ReadLine();
        }
    }
}
