using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Moise\Logs\log.text",a);

                    
        }
    }
}
