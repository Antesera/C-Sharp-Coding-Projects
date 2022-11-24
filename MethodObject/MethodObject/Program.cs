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
            employee.ID = Id;
            employee.FirstName = "Heni";
            employee.LastName = "Sami";
            employee.SayName();
                
            Console.ReadLine();
        }
    }
}
