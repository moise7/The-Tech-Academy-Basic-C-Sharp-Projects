using System;
using System.Collections.Generic;
using System.Text;

namespace Classeandmethod
{
    class Class
    {
        public static int  MethodOne(int a, int b)
        {
            int result = a + b;
            return result;
            //Console.WriteLine(a + b);
            
        }
        //adding a second method with same name 
        public static double MethodOne(double x, double a)
        {
            return x + a;
        }
        public static string MethodOne(string a, string b)
        {
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int num3 = num1 / num2;
            string result = Convert.ToString(num3);
            return result;
        }
    }
}
