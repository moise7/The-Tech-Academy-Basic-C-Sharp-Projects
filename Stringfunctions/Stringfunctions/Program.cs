using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings.
            string name = "Kristin";
            string quote = "The man said, \"Hello\", Kristin.\n Hello on a new line. \n \t hello on a tab.";
            string fileName = @"C:\Users\Kristin";


            //Convert a string to uppercase.
            name = name.ToUpper();

            Console.WriteLine(name);
            Console.ReadLine();
            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Mb");
            


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
