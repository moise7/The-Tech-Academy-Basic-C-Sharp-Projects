using System;

namespace FileAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number.
            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();
            //Logs that number to a text file.
            System.IO.File.WriteAllText(@"C:\Users\MB New Vision\Desktop\The Tech Academy\Framework\FileAssign\IO\text.txt", num);
            string num1 = System.IO.File.ReadAllText(@"C:\Users\MB New Vision\Desktop\The Tech Academy\Framework\FileAssign\IO\text.txt");
            Console.WriteLine(num1);
        }
    }
}
