using System;
using System.Collections.Generic;
using System.Text;

namespace OverLoad
{
     class Employee : Pesron
    {
        public int ID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName &&
                   ID == employee.ID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, ID);
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //but you should use return employee.ID == employee2.ID;
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
        }
        
     }
}
