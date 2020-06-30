using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        { //Takes an input from the user, multiplies it by 50
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = 50;
            int result = num * num1;
            Console.WriteLine(result);
            Console.ReadLine();

            //Takes an input from the user, adds 25
            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = 25;
            int add = num + num1;
            Console.WriteLine(add);
            Console.ReadLine();

            //Takes an input from the user, divides it by 12.5
            Console.WriteLine("Enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            
            double quotient = num4 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            //Takes an input from the user, checks if it is greater than 50
            Console.WriteLine("Enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            bool trueOrFalse = num5 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            //Takes an input from the user, divides it by 7
            Console.WriteLine("Enter a number: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            double dvid = num4 / 12.5;
            Console.WriteLine(dvid);
            Console.ReadLine();

            int remainder = dvid % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();



        }
    }
}