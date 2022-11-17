using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMaths
{
    class MathClass1
    {
        //private Variable
        private int _firstNumber;
        private int _secondNumber;

        //Constructor first number and second number
        public MathClass1(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        internal object Addition()
        {
            throw new NotImplementedException();
        }

        //default Constructor
        public MathClass1()
        {
            _firstNumber = 10;
            _secondNumber = 5;
        }
        //property to Set and Get _firstNumber
        public int FirstNumber
        {
            set
            {

            }
            get
            {
                return _firstNumber;
            }
        }
         
        public int secondNumber
        {
            set
            {
                _secondNumber = value;
            }
            get
            {
                return _secondNumber;
            }
        }
        //calls of multiple
        public int multiple()
        {
            return _firstNumber * _secondNumber;
        }
        //calls of addition
        public int add()
        {
            return _firstNumber + _secondNumber;
        }
        //calls of divide
        public int Divide ()
        {
            if (_firstNumber == 0)
                return 0;
            else
                return _firstNumber / _secondNumber;
        }
    }
}
