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
           
            Employee employee = listEmployees.Find(Employee => Employee.ID >= 5);
            Console.WriteLine("ID = {4},FirstName {4}", employee.ID, employee.FirstName);

            var Names = new List<string>();
            Names.ForEach(x =>Names.Add(x));
            Names.Add(FirstName => Joe, LastName => Bent);
            Names.Add(FirstName => Joe, LastName => George);
            Names.Add(FirstName => Joe, LastName => Sanford);

            var ID = new List<String>();
            ID.ForEach(X => ID.Add(X));
            ID.Add("Joe => 5");
            ID.Add("Tom => 6");
            ID.Add("Abre => 7");

            int count = listEmployees.Count(x => x.ID > 5);
            Console.WriteLine("Count = " + count);
        }
    }
}
