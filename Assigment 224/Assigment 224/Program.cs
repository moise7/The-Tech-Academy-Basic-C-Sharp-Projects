using System;

namespace Assigment_224
{
    class Program
    {
       public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Enter a number");
            
            
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You enter" + num1);

             class1.methodInt(num1);
            
        }
    }
}
