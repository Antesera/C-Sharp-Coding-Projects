using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp
{
    class Program
    {
    
        public static char consoleKeyInfo { get; private set; }

        static void Main(string[] args)
        {
            //one dimensional array
            //array using loops
            string[] students = { "Tom", "Victor", "Hakim", "Abti" };

            Console.WriteLine("Enter students name to search for");
            string studentsName = Console.ReadLine();

            bool contains = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (studentsName == students[i])
                {
                    contains = true;
                }
            }
            if (contains == true)
            {
                Console.WriteLine("The student is in the class");
            }
            else
            {
                Console.WriteLine("The student is NOT in the class");
            }

            //infinite loop
            int n = 11;
            do
            {
                Console.WriteLine("Hello World " + n);
                n++;
            }
            while (n < 10);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + " ");
            }
            //loop with operators
            for (int x = 1; x <= 6; x++)
            {
                if (x == 5)
                    continue;
                Console.WriteLine("Value is :{0}", x);
            }
            //unique list with loop
            var duplicatedItems = new List<int>() { 1, 1, 2, 3, 3, 4, 5, 5, 5 };
            var uniqueItems = duplicatedItems.Distinct();
            foreach (var item in duplicatedItems)
            {
                Console.WriteLine(item);
            }

            //create a list of values
            List<int> myvalues = new List<int>() { 23, 34, 45, 56, 67 };

            //Declare the integer loop variable beforehand
            int index = 0;

            //loop variable with 1 each loop cycle 
            foreach (int value in myvalues)
            {
                Console.WriteLine($"{index}: {value}");
                index++;
            }

            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Y)
            {
                Console.Clear();
            }
            else if (cki.Key == ConsoleKey.N)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Enter letters only");
            }

            // Part 1: two arrays are equal.
            string[] array1 = { "cat", "bird" };
            string[] array2 = { "cat", "bird" };
            Console.WriteLine(array1.SequenceEqual(array2));

            //all elements must be equal, no extra elements are allowed.
            string[] array3 = { "cat", "bird", "frog" };
            Console.WriteLine(array1.SequenceEqual(array3));

            Console.Write("Enter a number\n");
            int input = Convert.ToInt32(Console.ReadLine());// Convert to an integer

            if (!Int32.IsNumber(input)) // if not a whole number input give  an error
            {
                Console.WriteLine("Not an integer");
            }

            List<string> numbers = new List<string> { "1", "2" };
            List<string> numbers2 = new List<string> { "1", "2" };
            if (numbers.Equals(numbers))
            {
                Console.WriteLine();
            }

            var listnames = new List<string> { "A", "B", "A" };

            if (listNames.Distinct().Count() != listnames.Count())
            {
               Console.WriteLine("List contains duplicate value.");
            }

            Console.WriteLine("print array:");

            //Creat an array
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 1 };

            //foreach loop begin it will run till the last element of the array
            foreach(int items in a_array)
            {
                Console.WriteLine("which item are unique and duplicate");
            }

            //infinite loop
            int count = 0;

            while (true)
            {
                Console.WriteLine("Count = {0}.", count);
                count++;

                //...

                if (count > 10)
                {

                    break;
                }
            }
            Console.ReadLine();

        }
    }
}