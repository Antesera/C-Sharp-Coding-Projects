using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMaths
{
    class MathClass1
    {
       public int Add(int number1, int number2)
       {
            return number1 + number2;
       }
       public int AddByReference(ref int number1, ref int number2)
       {
            int result = number1 + number2;
            number1 *= 2;
            number2 *= 3;
            return result;
       }

       public int AddMultiple(int number1, params int[] numbers)
       {
            int result = 0;
            result += number1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
       }

       public int AddOptionalParametes(int number1, int number2,
           int number3 = 0,
           int number4 = 0)
       {
            return number1 + number2 + number3 + number4;
       }

    }
}
