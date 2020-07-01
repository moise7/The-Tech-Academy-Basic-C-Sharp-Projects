using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //Create a one-dimensional Array of strings
        string[] nameArray = new string[] { "Moise", "Kristin", "Paul" };
            string index = Console.ReadLine();
            Console.WriteLine("Select a name "+nameArray[index]);

        //Create a one-dimensional Array of integer
        int[] numArray = new int[] {5,10,25,30,100,100};
        int index = Console.ReadLine();
        Console.WriteLine("Select a number " + numArray[index]);

        List<string> intList = new List<string>();
        intList.Add("I love music");
        intList.Add("I love cars");
        intList.Remove("I like to Look good");
        Console.WriteLine("Select a sentence "+intList[0]);
        Console.ReadLine();
    }
    }

