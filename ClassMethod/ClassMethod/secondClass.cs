using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod
{
    class secondClass
    {
        //declaration of intialization
        public void whoAmI(string name)
        {
            Console.WriteLine("Hello "  + name  +  ", how are you doing?");
        }

        // property to  add two numbers
        public int addMe(int a, int b)
        {
            int totalValue = 0;
            totalValue = (a + b);
            return totalValue;
        }

        // property to  add three numbers
        public int addMe(int a, int b, int c)
        {
            int totalValue;
            Console.WriteLine("you are going to add 3 numbers");
            totalValue = (a + b + c);

            //double.totalValue = Add(1.0, +2.0 + 3.0);
            Console.WriteLine("total value of the three " + "double value:" + totalValue );
            return totalValue;
        }

        // property to  substract two numbers
        public int subMe(int a, int b)
        {
            int totalValue = 0;
            totalValue = (a - b);
            return totalValue;
        }
    }
}
