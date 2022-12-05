using System;
using System.Collections.Generic;
using System.Text;


namespace Enum
{
    //declared all Day Of Week values
    enum Weekdays { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("Current day of the week.");
            string input = Console.ReadLine();
            string first = input.ToLower();
           // bool inputparse = Enum.TryParse(first, out dayParse);
            
           //try block
            try
            {
                Weekdays day = new Weekdays();
                day = (Weekdays)System.Enum.Parse(typeof(Weekdays), input);
                Console.WriteLine(day);
            }
            //catch block
            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            return;
        }
    }
}

