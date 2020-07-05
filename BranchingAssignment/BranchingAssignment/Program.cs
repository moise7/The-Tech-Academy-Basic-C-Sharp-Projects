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
            int Weight=50;


            if (Weight > 50)
            {

                Console.WriteLine("Sorry, package too heavy to be shipped via Package Express. Have a good day.");



            }
            else
            {

                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimension = height + width + length;
                int result = length + width + height * Weight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + result);
                Console.ReadLine();


            }

        }






    }
        }
    
