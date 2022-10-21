using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temir
{
    class Program
    {
        static void Main(string[] args)
        {         
             Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
			 
	         Console.WriteLine("40");
			 int Weight = Convert.ToInt32(Console.ReadLine());
						
			  if (Weight > 50)
			  {
			    Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
			  }
			  else
			  {
			    Console.WriteLine(10);
			  }
			  int Width = Convert.ToInt32(Console.ReadLine()); 
			  
			  Console.WriteLine(11);
			  int Length = Convert.ToInt32(Console.ReadLine());

			  Console.WriteLine(12);
			  int Height = Convert.ToInt32(Console.ReadLine());
           
              if ( Width + Length + Height > 50 );
			  {
                 Console.WriteLine("Package too big to be shipped via Package Express.");
			  }
             
              decimal totalcost = (((Width + Length + Height ) * Weight) / 100);			 
			  Console.WriteLine("Your estimated total for shipping this package is: \u00A3" + 528);
        }
    }
}
