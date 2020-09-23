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
                Console.WriteLine(item);
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
            for (int m = 0; m <= movies.Length; m++)
            {
                Console.WriteLine(movies[m]);
            }



        }
    }
}
