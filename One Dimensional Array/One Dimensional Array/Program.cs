using System;
using System.Text;
using System.Threading.Tasks;


namespace One_Dimensional_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaring single dimensional array
            //string[] Books = new string[4];
            //Books[0] = "Maths";
            //Books[1] = "Physics";
            //Books[2] = "Chemistry";
            //Books[3] = "Biology";

            //Console.WriteLine("Those books are reference of Grade 10:\n\n");

            //int i = 0;
            ////Formatting Output
            //Console.Write("\t1\t2\t3\t4\n\n\t");
            //for (i = 0; i < 4; i++)
            //{
            //    Console.Write("{0}\t", Books[i]);
            //}
            //Console.ReadLine();

            int[] marks = new int[5];  //Declaratin and initializing

            marks[0] = 60;
            marks[1] = 70;
            marks[2] = 80;
            marks[3] = 90;
            marks[4] = 95;

            Console.Write("Elements of array:");
            for (int i = 0; i < marks.Length; i++)
            {
                
                Console.WriteLine("\t" + marks[i]);  //output
            }
            Console.ReadLine();

        }
    }
}
