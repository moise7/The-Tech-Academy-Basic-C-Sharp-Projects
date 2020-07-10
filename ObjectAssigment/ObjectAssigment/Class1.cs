using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAssigment
{
    public class Class1
    {
        public int method(int num1, int num2)
        {
            int result = num1 - num2;

            return result;
        }
        public double method(double num3, double num4)
        {
            double result = num3 * num4;
            Convert.ToInt32(result);
            return result;

        }
        public float method(float num5, float num6)
        {
            num5 = 10;
            float result = num5 + num6;
            Convert.ToInt32(result);
            return result;
        }
    }
}
