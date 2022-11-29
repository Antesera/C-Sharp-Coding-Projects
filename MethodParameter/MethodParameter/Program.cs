using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {

        public static string user2 { get; set; }

        static void Main(string[] args)
        {
            parameter1 MyObject = new parameter1();
            MyObject.MethodParameter1();

            
            Console.WriteLine("please type a number1");
            int user1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please type a number2");
            string User2 = Console.ReadLine();
               if (user2 = "")

                MyObject.add2ints(user1);

            else
                MyObject.add2int(user1, Convert.ToInt32(User2));
        }
    }
}

