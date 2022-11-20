using System;

namespace Polymorphism
{
    class Program

    {   
        interface IQuittable //
        {
            string name { get; set; }
            int goldvalue { get; set; }

            void Quite();

        }
        //define classes
        class Employee : IQuittable // implementation of interface
        {
            public string name { get; set; }
            public int goldvalue { get; set; }

            //define constractor
            public Employee (string _name)
            {
                name = _name;
                goldvalue = 100;
            }
            // void symbol method 
            public void Quite()
            {
                Console.WriteLine(name + " Quite.");
            }
        }
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Employee of Destiny");
            employee.Quite();

            Console.ReadLine();
        }
    }
}
