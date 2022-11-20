namespace OverLoad
{
    internal class ProgramBase
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee emp1 = employee;
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
}