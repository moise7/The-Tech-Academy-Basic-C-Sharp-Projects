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
            Console.WriteLine("Leave this blank");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            
            int result = ClassObject.method(num1);
            Console.WriteLine("Total\t\t{0} ",  result);
            Console.ReadLine(); 
            
        }
    }
}
