using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_224
{
    public static class Class1
    {
        public static void methodInt(int a)
        {
            int sum = a / 2;
            Console.WriteLine(sum);

        }
        public static int Value(out int a, out int b)
        {
            a = 7;
            b = 12;
            return a * b;
        }
        public static double Value(double x, double y)
        {
            return x + y;
            
        }
    }
}
