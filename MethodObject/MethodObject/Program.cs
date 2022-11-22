using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodObject
{
    class Program
    {
        public static int Id { get; private set; }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Dani";
            person.LastName = "Angu";

            Employee employee = new Employee();
            employee.ID = Id;

            Console.WriteLine(SayName());
            Console.ReadLine();
        }

        private static bool SayName()
        {
            throw new NotImplementedException();
        }
    }
}
