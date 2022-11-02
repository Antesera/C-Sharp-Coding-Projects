using System;
using System.Collections.Generic;

namespace Console_App_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            //int[] arr = new int[4] { 10, 20, 30, 40 };//declaration &initializzing

            ////rewrite this loop as a for each loop and run
            //for (int i = 0; i < arr.Length; i++)//create infinite loop 
            //{
            //    Console.WriteLine(arr[i]);//this statment will be printed
            //}
            //Console.ReadLine();

            //List<string> shoppingList = new List<string>(); 

            //shoppingList.Add("Oromia");
            //shoppingList.Add("Tizita");
            //shoppingList.Add("Fikir Eskemekabir");
            //shoppingList.Add("Tizita are depulicate");

            //for (int i = 0; i < shoppingList.Count; i++)
            //{

            //    Console.WriteLine(shoppingList[i]);
            //}

            //shoppingList.Remove("Tizita");

            //Console.WriteLine();
            //Console.ReadLine();// Waiting before closing


            int[] grades = { 66, 88, 95, 90, 100, 100, 100, 99, 44, 55 }; // initializing
                                                                          
            for (int i = 0; i < grades.Length; i++)   //for loop
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }
            //foreach loop
            foreach (int score in grades)
            {
                Console.WriteLine(score);  //print out
            }

            Console.ReadLine();

        }
     
    }
}
