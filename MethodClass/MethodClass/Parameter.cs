using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MethodClass
{
    class Parameter
    {
        private int Value1 { get; set; }
        private int value2 { get; set; }

         //declarative statement of the method
        public void MethodClass()
        {
            Console.WriteLine(addTwoIntegers(this.Value1, value2));
            Console.ReadLine();
        }
        public int MethodClass(int value1, int value2)
        {
            return addTwoIntegers(value1, value2);
        }

        //create two or more methods of the same name but difference signiture
        public int MethodClass(int value1, int value2, int maxTotal)
        {
            int total = addTwoIntegers(value1, value2);
            if (total > maxTotal) total = maxTotal;
            return total;
        }
        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
