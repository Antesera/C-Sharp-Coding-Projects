using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssign
{
    class Assig
    {
        public int AddNumber(int firstNumber, params int[] numbers)
        {
            int temp = 0;
            foreach (int tempNum in numbers)
            {
                temp += tempNum;
            }
            return temp + firstNumber;
        }

        public void MainMethod()
        {
            AddNumber(8);
            AddNumber(8, 9);
        }
    }
}
