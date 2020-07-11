using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAssigment
{
    public class Class1
    {
        public int method(int num1)
        {
            int result = num1;
            Convert.ToInt32(result);
            return result;
        }
        public int method1(int num2)
        {
            int result1 = num2;
           // decimal userInput = Convert.ToDecimal(Console.ReadLine());
            return result1;

        }
        public int method(string num3)
        {
           int x = 2;
             x = Convert.ToInt32(num3);

            return x;

        }
    }
}
