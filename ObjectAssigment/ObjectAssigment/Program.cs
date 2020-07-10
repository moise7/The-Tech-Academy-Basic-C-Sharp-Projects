using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAssigment
{
   public class Program
    {
      public  static void Main(string[] args)

        {
            // part 1
            //Console.WriteLine("Enter a number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Class1 class1 = new Class1();
            //int result;
            //result = class1.method(num1, num2);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //part 2
            Console.WriteLine("Enter a decimal number ");
            int num3 = (int)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Class1 class1 = new Class1();
            int result;
            result = class1.method(num3, num4);
            Console.WriteLine(result);
            Console.ReadLine();

            //part3

            //Console.WriteLine("Enter a number");

            //int num5 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number ")
            //int num6 = Convert.ToInt32(Console.ReadLine());
            //Class1 class1 = new Class1();
            //int result;
            //result = class1.method(num5, num6);
            //Console.WriteLine(result);
            //Console.ReadLine();





        }
    }
}
