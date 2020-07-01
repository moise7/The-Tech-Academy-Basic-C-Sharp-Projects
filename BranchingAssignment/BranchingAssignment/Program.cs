using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            Console.ReadLine();
            int packageWeight = 50;
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
               

            }
            else
            {
                Console.WriteLine("Proceed!!!");
            }
            Console.ReadLine();
           
            
            int length;
            Console.WriteLine("Please enter the package width: ");
         
            Console.ReadLine();

            Console.WriteLine("Please enter the package height:");
            int height;
            Console.ReadLine();

            Console.WriteLine("Please enter the package length:");
            int width;
            int result = length + height + width;
            Console.WriteLine("Your estimated total for shipping this package is: " + result);

            
        }
    }
}
