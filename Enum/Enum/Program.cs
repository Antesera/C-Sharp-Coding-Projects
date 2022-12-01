using System;

namespace Enum
{
    public enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Satureday, Sunday,

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("What day of this week is it?");
                Console.WriteLine("The day you picked was {2},pickDay -1")
                Console.ReadLine(); 
            }
               
            catch (Exception)
            {
                Console.WriteLine("please enter actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
