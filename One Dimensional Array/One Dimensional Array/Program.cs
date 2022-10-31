using System;
using System.Collections.Generic;
using System.Linq;
using System.RegularExpressions;

namespace One_Dimensional_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> myList = new List<string>();
            //myList.Add("Dani");
            //myList.Add("Mog");
            //myList.Add("Angu");

            //Console.WriteLine(myList.Count);


            char[] grades = new char[3];//declaration & initialization
            grades[0] = 'a';
            grades[1] = 'b';
            grades[2] = 'c';

            Console.WriteLine(grades.Length);//yields 3

            Console.WriteLine(grades[1]); //yields B
            Console.ReadLine();


            // Declaring Single Dimensional array
            //String[] books = new String[4];
            //books[0] = "maths";
            //books[1] = "physics";
            //books[2] = "chemistry";
            ///books[3] = "biology";

            //console.writeline("all the element of books array is:\n\n");

            //int i = 0; //formatting output
            //console.writeline("\t1\t2\t3\t4\n\n\t");
            //for (i = 0; i < 4; i++)
            //{
            //    console.write("{0}\t", books[i]);
            //}


            Console.ReadLine();
        }
    }
}
