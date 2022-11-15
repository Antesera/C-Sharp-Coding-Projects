using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    class SeraClass
    {
        public void whoAmI(string name)
        {
            Console.WriteLine("Hello" + name + ",  How are doing ?");
        }
        public int addMe(decimal b)
        {
            int totalvalue = (Convert.ToInt32(b) + 3);
            //totalvalue = ( a + b);
            return totalvalue;
        }

        public int addMe(string c)
        {
            int totalvalue = (Convert.ToInt32(c) + (3 + 8));
            Console.WriteLine(" you are going to add 3 numbers");
            //totalvalue = (a + b + c);
            return totalvalue;
        }

        public int subMe(int a, int b)
        {
            int totalvalue = 0;
            //totalvalue = (a - b);
            return totalvalue;
        }

    }
}
