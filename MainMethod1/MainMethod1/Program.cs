﻿using System;
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
            
            Math.AddMe(a);
            Math.AddMe(b);
            Math.AddMe(c);

            Console.WriteLine(Math.AddMe(9));
            Console.WriteLine(Math.AddMe(8.0m));
            Console.WriteLine(Math.AddMe("12"));
            Console.ReadLine();
        }
    }
}
