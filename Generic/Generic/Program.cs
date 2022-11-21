using System;
using System.Collections.Generic;

namespace Generic
{
    class Employee
    {
        //main void
        private static void Main(string[] args)
        {
            Console.WriteLine(Thing.CompareValues (12, "Hello"));
            Console.WriteLine(Thing.CompareTypes ("Hello", "Hello"));
           
            bool Equal = Thing.AreEqual(1, 1);
             
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.ReadLine();
        }
    }

    //contractor
    public class Thing
    {
        //type parameter using brackets
        public static bool CompareValues<T01, T02>(T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }
        public static bool CompareTypes<T01, T02>(T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
        public static bool AreEqual<T01, T02>(T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

    }
}

