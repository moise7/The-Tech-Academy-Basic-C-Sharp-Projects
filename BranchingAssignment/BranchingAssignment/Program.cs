using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
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
            // when I put weight = 50 the program will run until get to end that I have the cost of the shipping 
            // but it's does not do anything when I enter a number bigger than 50 the program keep on continue
            // when i put int weight = convert.ToInt32(Console.ReadLine());
            // the program just stuck on the number
            //int Weight=50;
            int Weight = Convert.ToInt32(Console.ReadLine());

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
                   
                    

                    if (dimension > 50)

                {
                    Console.WriteLine("Package too big to be shipped");
                }
                else
                {
                    int result = length + width + height * Weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + result);
                    Console.ReadLine();
                }
                


            }

        }






    }
        }
    
