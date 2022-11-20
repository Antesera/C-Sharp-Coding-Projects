﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

namespace OverLoad
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "Firez";
            emp1.LastName = "Tesh";

            Employee emp2 = new Employee();
            emp2.Id = 1;
            emp2.FirstName = "Firez";
            emp2.LastName = "Tesh";

            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 is equal to emp2");
            }
            else
            {
                Console.WriteLine("emp1 is not equal to emp2");
            }

            Console.Read();
        }
    }

    public class Employee : IEquatable<Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }  

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id) 
                && emp1.FirstName.Equals(emp2.FirstName,StringComparison.OrdinalIgnoreCase)
                && emp1.LastName.Equals(emp2.LastName,StringComparison.OrdinalIgnoreCase)
               )
            {
                return true;
            }
            return false;
 
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {

            if (!emp1.Id.Equals(emp2.Id)
               //&& !emp1.FirstName.Equals(emp2.FirstName, StringComparison.OrdinalIgnoreCase)
               //&& !emp1.LastName.Equals(emp2.LastName, StringComparison.OrdinalIgnoreCase)
               )
            {
                return true;
            }
            return false;
        }

        public bool Equals(Employee other)
        {
            return other.Id.Equals(this.Id)
                && other.FirstName.Equals(this.FirstName, StringComparison.OrdinalIgnoreCase)
                && other.LastName.Equals(this.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
