using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainMethod1
{
    class Program
    {
        private static decimal a;
        private static decimal b;
        private static decimal c;

        public static void Main()
        {
            MainMethod1.Sera Math = new MainMethod1.Sera();

            Math.WhoAmI("Ante");
            Math.AddMe(a);
            Math.AddMe(b);
            Math.AddMe(c);

            Console.WriteLine(3 + 8);
            Console.WriteLine(8 + 4);
            Console.WriteLine(4 + 3);
            Console.ReadLine();
        }
    }
}
