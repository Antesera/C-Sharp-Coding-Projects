using System;
using System.Collections.Generic;

namespace MainMethod1
{
    public class Sera
    {       
        //Constructor the string
        //public void WhoAmI(string name)
        //{
        //    Console.WriteLine("Hello" + name + ", How are doing ?");
        //}

        //default Constractor
        public int AddMe(decimal a)
        {
            int result = (Convert.ToInt32(a) + 8);
            return result;
        }       
        public int AddMe(string c)
        {

            int result = (Convert.ToInt32(c) + 3);
            return result;
        } 
    }
}
