using System;
using System.Collections.Generic;
using System.Text;

namespace MathClass2
{
    class Separete
    {
        public double GetAdd(int data)
        {
            data = data + 4;
            return GetSubstract(data);
        }

        private double GetSubtract(double data)
        {
            data = data - 3;
            return GetDivide(data);
        }

        private  double GetDivide(double data)
        {
            return data / 3;
        }
    }

}
