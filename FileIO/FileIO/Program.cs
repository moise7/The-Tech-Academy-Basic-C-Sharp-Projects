using System;
using System.IO;
using System.Net.Http.Headers;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.ReadLine();
           
            string a = File.ReadAllText(@"C:\Users\Moise\Logs\log.text");
            File.WriteAllText(@"C:\Users\Moise\Logs\log.text", a);

            Console.WriteLine("The number is {0}",a);
                    
        }
    }
}
