﻿using System;

namespace Classeandmethod
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Class ClassObject = new Class();
            int result;
            result = Class.MethodOne(3, 5);
            Console.WriteLine(result);
            //instantiating a class and call the second method, passing in a decimal. Display the result to the screen.
            double result2 = Class.MethodOne(2.4, 7.9);
            Console.WriteLine(result2);
            //instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen
            string result3 = Class.MethodOne("7", "9");
            Console.WriteLine(result3);
        }
    }
}
