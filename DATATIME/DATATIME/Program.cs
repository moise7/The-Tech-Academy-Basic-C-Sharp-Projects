using System;

namespace DATATIME
{
    class Program
    {
       public static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            Console.WriteLine(a, now);

        }
    }
}
