using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{                  
    class Program
    {
        static void Main(string[] args)
        {
            ClassMethod.secondClass clMath = new ClassMethod.secondClass();

            clMath.whoAmI("Ante");
            
            Console.WriteLine(clMath.addMe(3, 8));
            Console.WriteLine(clMath.addMe(3, 8, 4));
            Console.WriteLine(clMath.subMe(3, 8));

            Console.ReadLine();

        }
    }
}
