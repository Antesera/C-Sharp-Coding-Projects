using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass2
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            string Line = Console.ReadLine();

            var separateObject = new Separate(); // you have to add reference, if is not
            var result = SeparateObject.GetAdd(data);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
