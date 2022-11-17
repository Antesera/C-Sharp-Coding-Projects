using System;
using System.Collections.Generic;
using System.Text;

namespace MethodAssign
{
    class AssigClass
    {

        private string name;
        private int age;
        private double finalGrade;

        public AssigClass(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }
        public AssigClass(string name, int age)
           : this(name, age, 0)
        {

        }
        public void sayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
        public string Name
        {
            get
            {
                if(age >= 18)
                {
                    return name;
                }
                else
                {
                    return "This AssigClass is too young";
                }
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                if (age >= 18)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value != 0)
                {
                    age = value;
                }
            }
        }
        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;

            }
        } 
    }
}
