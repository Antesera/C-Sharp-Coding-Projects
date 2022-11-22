using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodObject
{
    class Program
    {
        public static int Id { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Dani";
            person1.LastName = "Angu";

            Employee employee = new Employee();
            Employee employee1 = employee;
            employee1.ID = Id;

            Console.WriteLine (employee1.SayName("Name:" + FirstName + LastName));
            Console.ReadLine();
        }
    }
}
