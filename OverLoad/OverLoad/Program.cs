using System;

namespace OverLoad
{
    class Program   
    {
        static void Main(string[] args)
        {
            Employee Eg = new Employee();
            Eg.FirstName = "Bela";
            Eg.LastName = "Abera";
            Eg.ID = 9112323;

            Employee Eg1 = new Employee();
            Eg.FirstName = "shashe";
            Eg.LastName = "Mesfi";
            Eg.ID = 3906054;

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
