using System;
using System.Text;

namespace Construct_Assign
{  
    class Program
    {
        
        static void Main(string[] args)
        {

            const int myNum = 15;
            Console.WriteLine(myNum);

            var c = 12;
            var d = 15;
            var e = 'S';
            var f = "Hi";

            // to print their type of variables
            Console.WriteLine("value of c {0}, type {1}", c, c.GetType());
            Console.WriteLine("value of d {0}, type {1}", d, d.GetType());
            Console.WriteLine("value of e {0}, type {1}", e, e.GetType());
            Console.WriteLine("value of f {0}, type {1}", f, f.GetType());

            Console.ReadLine();
        }
    }
}
