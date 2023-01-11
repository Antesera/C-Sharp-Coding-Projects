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
            //part one 
            //one dimensional array
            //array using loops
            string[] students = { "Tom", "Victor", "Hakim", "Abti" };

            Console.WriteLine("please enter some text");//write the name to get string number
            string studentsName = Console.ReadLine();

            
            for (int i = 0; i < students.Length; i++)
            {
                students[i] += studentsName;//write string number to describe the name of student
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            //part two

            //infinite loop
            int n = 11;
            do
            {
                Console.WriteLine("Hello World " + n);
                n++;//added n++ to make not infinite
            }
            while (n < 10);


            //part three
            //loop with operators
            for (int x = 1; x <= 6; x++)
            {
                if (x == 5)
                    continue;
                Console.WriteLine("Value is :{0}", x);//string  value of 0, lessthan or equal to six
            }
            for (int x = 1; x < 6; x++)
            {
                if (x == 5)
                    continue;
                Console.WriteLine("Value is :{0}", x);//string  value of 0, lessthan six
            }


            //part four
            //unique list with loop
            var ustring = new List<string> { "apple", "orange", "bannana" };//unique item list 
            Console.WriteLine("please enter a fruit");
            var uniqueItems = Console.ReadLine();

            for (int y = 0; y < ustring.Count; y++)
            {
               if(ustring[y]== uniqueItems)
               {
                    Console.WriteLine(y);
                    break;//stop and run the program
               }
                    
            }
            if (!ustring.Contains(uniqueItems))
            {
                Console.WriteLine("The item is not the list");
            }


            //part five
            //create a list of values
            var ustringl = new List<string> { "apple", "orange", "bannana", "apple" };//duplicate item list
            Console.WriteLine("please enter a fruit");
            var items = Console.ReadLine();

            for (int y = 0; y < ustringl.Count; y++)
            {
                if (ustringl[y] == items)
                {
                    Console.WriteLine(y);                  
                }

            }
            if (!ustringl.Contains(items))//the items is not found in the list
            {
                Console.WriteLine("The item is not the list");
            }


            //part six
            var ustring2 = new List<string> { "apple", "orange", "bannana", "apple" };//list of duplicate item
            
            List<string> ustring3 = new List<string>();


            foreach (string x in ustring2)
            {
                if (ustring3.Contains(x))
                {
                    Console.WriteLine(x + " - this item is a duplicate");//out put of duplicate items

                }
                else
                {
                    Console.WriteLine(x + " - this item is a unique");//out put of unique items
                }
                ustring3.Add(x);
            }
            Console.ReadLine();
        }
    }
}