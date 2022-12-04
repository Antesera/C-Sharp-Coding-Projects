using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID = 101,FirstName = "Bela", LastName = "Abera"},
                new Employee{ID = 102,FirstName = "shashe",LastName = "Mesfi"},
                new Employee{ID = 103,FirstName = "Joe", LastName = "Feta"},
                new Employee{ID = 104,FirstName = "Joe", LastName = "Awoko"},
                new Employee{ID = 105,FirstName = "Aman", LastName = "Tolla"},
                new Employee{ID = 106,FirstName = "shibru", LastName = "Malto"},
                new Employee{ID = 107,FirstName = "Sora", LastName = "Sobsa"},
                new Employee{ID = 108,FirstName = "Animu", LastName = "Zewge"},
                new Employee{ID = 109,FirstName = "Mamo", LastName = "Abi"},
                new Employee{ID = 110,FirstName = "Tata", LastName = "Gebre"},
            };

            Employee employee = listEmployees.Find(Employee => Employee.ID == 102);
            Console.WriteLine("ID = {0},FirstName {1}", employee.ID, employee.FirstName);

            int count = listEmployees.Count(x => x.LastName.StartsWith("A"));
            Console.WriteLine("Count = " + count);
        }
        public  static bool Employee()
        {
            return Employee.ID >= 105;
        }
    }
}
