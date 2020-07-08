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
        public int methodOne(int num3, int num4)
        {
            int result = num3 * num4;
            return result;

        }
        public int last(int num5, int num6)
        {
            num5 = 10;
            int result = num5 + num6;
            return result;
        }
    }
}
