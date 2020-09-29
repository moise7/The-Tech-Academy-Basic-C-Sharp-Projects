using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                int[] numArray = { 23, 56, 78, 67, 45, 88 };
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int result;
                foreach(int item in numArray)
                    {
                 Console.WriteLine(result = item / num);
                Console.ReadLine();
                    }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a different number");
                Console.ReadLine();
            }
    }
    }
}