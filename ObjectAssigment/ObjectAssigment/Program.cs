﻿using System;
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
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Class1 class1 = new Class1();
            int result;
            result = class1.method(num1);
            Console.WriteLine(result);
            Console.ReadLine();

            //part 2
            Console.WriteLine("Enter a decimal number ");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int num3 = Convert.ToInt32(Console.ReadLine());
           
            Class1 method1Object = new Class1();
            int result1;
            result1 = class1.method1(num2);
            Console.WriteLine(result1);
            Console.ReadLine();

            //part3

            Console.WriteLine("Enter a number");
            
            num3 = Convert.ToInt32(Console.ReadLine());
            Class1 methodObject = new Class1();
            int result2;
            result2 = class1.method(num3);
            Console.WriteLine(result2);
            Console.ReadLine();





        }
    }
}
