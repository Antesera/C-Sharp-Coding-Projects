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
                Console.WriteLine(addTwoIntegers("Enter first number"));
                int value1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(addTwoIntegers("Enter second number"));
                //int num2 = Convert.ToInt32(Console.ReadLine());
            }

            int result = addTwoIntegers(num1, num2);
            return result;
        }
        
        private int addTwoIntegers(int num1 ,int num2 = 0)
        {
            int sum = num1 + num2;
            return sum;
        }


     }
       
}
