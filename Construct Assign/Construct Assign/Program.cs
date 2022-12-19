using System;
using System.Text;

namespace Construct_Assign
{
    public class Bar
    {
        public int Amount { get; set; }

        public Bar() :this(null, 0)
        {
        }

        public Bar(int amount) :this(string.Empty, amount)
        {

        }

        public Bar(string name, int amount) : base(name) 
        {
            this.Amount = amount;
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First construct!");
            Bar a = new Bar();
            Console.WriteLine("Second construct!");
            Bar b = new Bar();
            Console.WriteLine("Third construct!");
            Bar c = new Bar();

            Console.ReadLine();
        }
    }
}
