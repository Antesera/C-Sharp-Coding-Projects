using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod1
{
    class seraClass1
    {
        //private field with initial values
        private int a = 3;
        private int b = 8;
        private int c = 4;

        //Constractor the string
        public void WhoAmI(string name)
        {
            Console.WriteLine("Hello" + name + ", How are doing ?");
        }
        //default Contractor
        public int addMe(decimal b, int v)
        {
            int totalvalue = (Convert.ToInt32(b) + 3);
            //totalvalue = (a + b);
            return totalvalue;
        }

        //default Contractor
        public int addMe(int v, string c)
         {
            int totalvalue = (Convert.ToInt32(c) + (3 + 8));
            //totalvalue = (a + b + c);
            return totalvalue;
         }
   
        
    }
}
