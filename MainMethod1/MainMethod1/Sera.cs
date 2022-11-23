using System;
using System.Collections.Generic;

namespace MainMethod1
{
    public class Sera
    {
        private int a = 3;
        private int b = 8;
        private int c = 4;

          //Constructor the string
        public void WhoAmI(string name)
        {
            Console.WriteLine("Hello" + name + ", How are doing ?");
        }

        //default Constractor
        public int AddMe(decimal b)
        {
            int result = (Convert.ToInt32(b) + 3);
            return result;
        }
    }
}
