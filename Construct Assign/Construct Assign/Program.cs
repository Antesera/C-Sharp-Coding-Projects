using System;
using System.Linq;

namespace Construct_Assign
{
   public class ConstructMe
    {
        public string name;
        public int id;
        public ConstructMe (string Name, int id)
        {
            this.name = Name;
            this.id = id;
        }
    }
    class Program
    {
        const int a = 10;
        static void Main(string[] args)
        {
            ConstructMe a = new ConstructMe("Daniel", 28);
            Console.WriteLine($"The instance with name: {nameof(a)}, has property name: {a.name} and id: {a.id}");
            
            Console.ReadKey();
        }
    }
}
