using System;
using System.Collections.Generic;
using System.Text;

namespace MethodCl
{
    class MethodClass
    {
        //private int num1 { get; set; }
        //private int num2 { get; set; }

        int num1 = 4;
        int num2 = 12;

        public void OutPut(int number1, int number2)
        {
            int value = number2 / number1;
        }
        public void Output(int number1, int number2, out int result)
        {
            result = number1 / number2;
        }
    }
    
}
