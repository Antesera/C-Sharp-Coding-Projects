using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass1 plus = new MathClass1();
            int number1, number2;
            number1 = 5;
            number2 = 15;
            plus.Add(number1, number2);
            plus.AddByReference(ref number1, ref number2);
            plus.AddMultiple(5, 11, 7, 23, 53);

            Console.WriteLine(plus.Add(number1, number2));
            //Console.WriteLine(plus.AddByReference(ref number1, ref number2));
            Console.WriteLine(plus.AddMultiple(5, 11, 7, 23, 53));

            
        }
    }
}

