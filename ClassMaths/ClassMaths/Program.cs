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
            MathClass1 Class1 = new MathClass1();

            
            Console.WriteLine("please enter the number");

            int div = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Class1.multiple(div).ToString());
            Console.WriteLine(Class1.add(div).ToString());
            Console.WriteLine("Divide Result: " + Class1.Divide(div));
        }
    }
}

