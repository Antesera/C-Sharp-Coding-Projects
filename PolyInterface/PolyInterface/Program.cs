using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PolyInterface
{
    class Program
    {
        interface IQuittable  //constractor of Interface
        {
            void Quite();
        }
        class Employee : IQuittable
        {
            public void Quite()
            {
                Console.WriteLine("Employee have Quite mistake at work station");
            }
        }
        class Salary : IQuittable
        {
            public void Quite()
            {
                Console.WriteLine("Employee was quite soon to get ovettime");
            }
        }
        class Benefit : IQuittable
        {
            public void Quite()
            {
                Console.WriteLine("Employee was quite a sudden change by companys gift!");
            }
        }

        static void Main(string[] args)
        {
            IQuittable employee = new Employee(); //Employee  instantiate at IQuittable
            employee.Quite();

            Salary salary = new Salary();
            salary.Quite();

            Benefit benefit = new Benefit();
            benefit.Quite();

        }
    }
}
