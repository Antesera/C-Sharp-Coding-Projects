using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            parameter1 MyObject = new parameter1();
            MyObject.MethodParameter1();

            
            Console.WriteLine("please type a number");
            int user1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please type a number");
            int user2 = Convert.ToInt32(Console.ReadLine());
            MyObject.addTwoIntegers(user1, user2);

        }
    }
}

