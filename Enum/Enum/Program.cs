using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    enum Weekdays { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("Current day of the week.");
            string input = Console.ReadLine();
            string first = input.ToLower();
            OneWeek.DaysOfTheWeek dayParse;
            bool inputparse = Enum.TryParse(first, out dayParse);
            
            try
            {
                if (inputparse == true)
                {
                    Console.WriteLine("yes,it's + input");
                }
            }

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

