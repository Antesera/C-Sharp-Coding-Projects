using System;
using System.Collections.Generic;
using System.Text;

namespace MyMathClass
{
    class MathClass
    {
        //private variables
        private int _firstNumber;
        private int _secondNumber;
         //Constructor first number and second number
        public MathClass(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
         //Default Constructor
        public MathClass()
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

        public int SecondNumber
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
        //Calls of multiple 
        public int Multiple()
        {
            return _firstNumber * _secondNumber;
        }

        public int Divide()
        {
            if (_firstNumber == 0)
                return 0;

            else
            return _firstNumber / _secondNumber;

        }
    }
}
