using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAssigment1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("You don't have to enter the second number " );
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Class1 class1 = new Class1();
          int result;
            if (num2 == 1)
            {
                Class1.math(num1);
            }
            else 
            {
                Class1.math(num1, num2);
            }
            result = Class1.math(num1, num2);

            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}
