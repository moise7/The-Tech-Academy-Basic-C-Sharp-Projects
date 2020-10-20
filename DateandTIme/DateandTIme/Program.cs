using System;

namespace DateandTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
            Console.WriteLine("Enter a number");
           int num = Convert.ToInt32(Console.ReadLine());
            DateTime d2 = now.AddHours(num);
            Console.WriteLine("the exaxt time "+d2);
        }
    }
}
