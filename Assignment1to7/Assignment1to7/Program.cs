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

            Console.WriteLine("type a text ");
            var i = Console.ReadLine();
            foreach (var item in movies)
            {
                Console.WriteLine(item +  i);

            }
            //creating an infinite loop
           // for (int a = 0; 0 < 50; a++)
            //    Console.WriteLine("value:{0}", a);

            // }
            //fixing loop
            for (int a = 0; a< 50; a++)
            {
                Console.WriteLine("value:{0}", a);

            }
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
                var a = Console.ReadLine();
                foreach (string name in names)
                {
                    if (name == a)
                    {
                        Console.WriteLine(name);break;
                    }
                    else
                    {
                        Console.WriteLine("No in the List try again");
                    }
                }
            }
            //Add code to the loop that tells a user if they put in text that isn’t in the list
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Create a list of strings that has at least two identical strings in the list
            List<string> nicknames = new List<string>() { "Nick", "MB", "momo", "MB", "momo", "lukage", "Louis" };
            Console.WriteLine("Type a nicknames");
            string userNicks = Console.ReadLine();
            foreach (string nickname in nicknames)
            {
                if (nickname == userNicks)
                {
                    Console.WriteLine(nickname);
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Try again");
                }
            }
            //Create a list of strings that has at least two identical strings in the list
            List<string> states = new List<string>() { "Indiana", "Chicago", "DC", "New York", "DC", "Atlanta" };
            
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list
            foreach (string state in states)
            {
                for (int i = 0; i < states.IndexOf(state); i++)
                {
                    if (state == states[i])
                    {
                        Console.WriteLine(state + " has appeared before in this list.");
                    }
                }
            }
        }


    }
}
