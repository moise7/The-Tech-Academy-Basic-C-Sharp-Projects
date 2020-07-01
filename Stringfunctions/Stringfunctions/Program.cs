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
            string name1 = "Kristin";
            string name2 = "The man said, \"Hello\", Kristin.\n Hello on a new line. \n \t hello on a tab.";
            string name3 = @"C:\Users\Kristin";
            string strFinal = name1 + name2 + name3;


            //Convert a string to uppercase.
            name1 = name1.ToUpper();

            Console.WriteLine(strFinal);
            Console.ReadLine();
            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append(" My name is Mb");
            sb.Append(" Nice to meet you. ");
            sb.Append("How are you today?");



            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
