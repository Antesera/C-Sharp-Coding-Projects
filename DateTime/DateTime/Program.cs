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
            System.DateTime now = System.DateTime.Now;

            //print current date and Time 
            Console.WriteLine(now);
            
            Console.WriteLine("please enter the DateTime of next Tomorrow ?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(now.AddHours(x));
            Console.ReadLine();
        }
    }
}
