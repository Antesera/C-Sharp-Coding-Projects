using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Dan";
            person.LastName = "Angu";

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = id;
            

            Console.WriteLine(person.GetFullName());
            Console.ReadLine();


        }
    }

   
}
