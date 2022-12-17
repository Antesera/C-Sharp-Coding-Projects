using System;
using System.Text;

namespace Construct_Assign
{
    public class NewEmployee
    {
        public string firstName;
        public string lastName;
        public string empId;
        public string position;
        public string team;
        public NewEmployee() :this("Default firstName","default lastName")
        {
            Console.WriteLine("Reserving new record for the upcoming employee.");
        }
        public NewEmployee(string firstName) :this(firstName,"Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, withfirstName!");
        }
        public NewEmployee(string firstName, string lastName) :this(firstName, lastName, "CNT01","Network Analyst","Network team")
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Console.WriteLine("Creating new record for the upcoming employee, with firsName and lastName!");
        }
        public NewEmployee(string firstName, string lastName, string empId, string position, string team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empId = empId;
            this.position = position;
            this.team = team;
            Console.WriteLine("creating new record for the upcoming employee, with firstName, lastName, empId, position and team!");
        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("First construct!");
            NewEmployee a = new NewEmployee();
            Console.WriteLine("Second construct!");
            NewEmployee b = new NewEmployee("Aman");
            Console.WriteLine("Third construct!");
            NewEmployee c = new NewEmployee("Aman", "Alem");

            Console.ReadLine();
        }
    }
}
