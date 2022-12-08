using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class DateTime
    {
        public static DateTime Now { get; set; }
        public static object date02 { get;  set; }

        static void Main(string[] args)
        {
            //DateTime properties
            DateTime now = DateTime.Now;
            //var tomorrow = date02.AddDays(1);

            //print current date and Time 
            Console.WriteLine(now);
            //
            Console.WriteLine("please enter the DateTime of next Tomorrow YY-MM-DD formate?");
            Console.ReadLine();
        }
    }
}
