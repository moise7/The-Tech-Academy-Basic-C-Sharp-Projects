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
            return a / b;
        }
    }
}
