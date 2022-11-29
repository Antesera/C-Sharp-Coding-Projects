using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MethodParameter
{
    class parameter1
    {
        private int num1 { get; set; }
        private int num2 { get; set; }

        //declarative statement of the method

        public void MethodParameter1()
        {
            
        }
        public int MethodParameter1( int num1, int num2)
        {
            
            try
            {
                addTwoIntegers(num1, num2);
            }
            catch
            {
                addTwoIntegers(num1);
               
            }

            int result = addTwoIntegers(num1, num2);
            return result;
        }

        internal void add2int(int user1, int v)
        {
            throw new NotImplementedException();
        }

        internal void add2ints(int user1)
        {
            throw new NotImplementedException();
        }

        public int addTwoIntegers(int num1 ,int num2 = 0)
        {
            int sum = num1 + num2;
            return sum;
        }


     }
       
}
