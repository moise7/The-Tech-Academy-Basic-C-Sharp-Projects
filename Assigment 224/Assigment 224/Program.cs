using System;

namespace Assigment_224
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Objectmethod = new Class1();
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sum = Objectmethod.methodInt(num1);
            
        }
    }
}
