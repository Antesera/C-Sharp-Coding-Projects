using System;

namespace MyMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass myClass = new MathClass();
            
            myClass.FirstNumber = 10;
            myClass.SecondNumber = 5;

            Console.WriteLine(myClass.Multiple().ToString());

            Console.WriteLine("Divide Result: " + myClass.Divide());

            Console.ReadLine();
        }
    }
}
