using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandObjectsAss
{
   public class Program
    {
       public static void Main(string[] args)

        {
            Console.WriteLine("Please enter a number:  ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Class1 class1 = new Class1();
            int result;
            result = class1.methodOne(num1, num2);
            Console.WriteLine(result);


            //Class2 class2 = new Class2();
          
            
            Console.ReadLine();
        }
      
    }
}
