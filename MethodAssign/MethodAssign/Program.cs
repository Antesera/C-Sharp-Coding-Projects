using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodAssign
{
    class Program
    {
        private static int temp;
        public static int FirstNumber { get; set; }
        public static int SecondNumber { get; set; }
        private static int TempNum;

        static void Main(string[] args)
        {
            MethodAssign.Assig X = new MethodAssign.Assig();
            {
                FirstNumber = FirstNumber;
                TempNum = temp + FirstNumber;
            }

            Console.WriteLine( "Sum:" + "FirstNumber  + params int[] numbers");
        }
    }
}
