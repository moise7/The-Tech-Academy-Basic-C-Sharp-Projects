using System;

namespace Assigmnet220
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ClassObject = new Class1();
            Console.WriteLine("enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number or simply hit enter");
            string num2 = Console.ReadLine();
            if (num2=="")
            {
                Console.WriteLine(ClassObject.method(num1));
               
            }else
            {
                int num =Convert.ToInt32(num2);
                Console.WriteLine(ClassObject.method(num1, num));
                Console.ReadLine();

            }


        }
    }
}
