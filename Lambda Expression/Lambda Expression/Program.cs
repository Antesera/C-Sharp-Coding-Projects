using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Expression
{
    class Program
    {
        private static object employee;
        public static int EmployeeID { get; set; }
        public static int ID { get; private set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID = 1,FirstName = "Bela", LastName = "Abera"},
                new Employee{ID = 2,FirstName = "shashe",LastName = "Mesfi"},
                new Employee{ID = 3,FirstName = "Joe", LastName = "Feta"},
                new Employee{ID = 4,FirstName = "Joe", LastName = "Awoko"},
                new Employee{ID = 5,FirstName = "Aman", LastName = "Tolla"},
                new Employee{ID = 6,FirstName = "shibru", LastName = "Malto"},
                new Employee{ID = 7,FirstName = "Sora", LastName = "Sobsa"},
                new Employee{ID = 8,FirstName = "Animu", LastName = "Zewge"},
                new Employee{ID = 9,FirstName = "Mamo", LastName = "Abi"},
                new Employee{ID = 10,FirstName = "Tata", LastName = "Gebre"},
            };

            //List with each name of type Employee
            List<Employee> EmpJoe = new List<Employee>();
            EmpJoe = listEmployees.Where(Employee => Employee.Joe == FirstName).ToList();
            foreach (Employee employees in listEmployees)
            {
                if (employees.FirstName == "Joe")
                {
                    EmpJoe.Add(employees);
                    
                }
            }
            Console.WriteLine($" Found(name) is the first name is the same");

            //List with each Employee ID greater than  Five
            List<Employee> EmpID = new List<Employee>();
            EmpID = listEmployees.Where(Employee => Employee.ID >= 5).ToList();
            foreach (Employee employees in listEmployees)
            {
                if (employee.ID > 5)

                {
                    EmpID.Add(employee);
                }
            }
            
            Console.WriteLine($" Found(Name) is greater than Five");
            Console.ReadLine();
        }
    }
}
