using System;
using System.Collections.Generic;

namespace Assignment1to7
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a one-dimensional array of strings
            string[] movies = { "black panther", "Avengers", "X-man" };

            Console.WriteLine("type a text");
            Console.ReadLine();
            foreach (var item in movies)
            {
                Console.WriteLine(item+movies);
                Console.ReadLine();
            }
            //creating an infinite loop
            // for (int a = 0; 0 < 50; a++)
            //  {
            //    Console.WriteLine("value:{0}", a);

            // }
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
            for (int j = 0; j < movies.Length; j++)
            {
                Console.WriteLine(movies[j]);
            }
            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
            for (int m = 0; m <= movies.Length-1; m++)
            {
                Console.WriteLine(movies[m]);
            }
            try
            {
                // A list of strings where each item in the list is unique
                List<string> names = new List<string>() { "Moise", "Erik", "Adam", "Daniel" };
                Console.WriteLine("Type a text here..");
                Console.ReadLine();
                foreach (string name in names)
                {
                    if (name == "Moise")
                    {
                        Console.WriteLine(name);
                    }
                }
            }
            //Add code to the loop that tells a user if they put in text that isn’t in the list
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
