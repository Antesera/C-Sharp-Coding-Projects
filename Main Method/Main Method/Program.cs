using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Main_Method.SeraClass ClMath = new Main_Method.SeraClass();

            ClMath.whoAmI("Ante");

            Console.WriteLine(ClMath.addMe(8, 3));
            Console.WriteLine(ClMath.addMe(3,8,4));
            Console.WriteLine(ClMath.SubMe(3,8));
        }
    }
}
