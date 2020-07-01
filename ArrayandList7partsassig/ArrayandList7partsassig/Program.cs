using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //part one
        string[] names = new string[] { "Moise", "Kristin", "Paul" };

        Console.WriteLine("Enter a text: ");
        Console.ReadLine();
        foreach (string name in names)
        {
            Console.WriteLine(name);
            Console.ReadLine();

            //part 2
        int count = 0;
            while (true)
            {
                Console.WriteLine("count = {0}.", count);

                if (count > 35)
                {
                    break;
                }
            }
           // part 3
        int count = 0;
            while (true)
            {
                Console.WriteLine("count = {0}.", count);
                count++;
                if (count > 35)
                {
                    Console.ReadLine();
                    break;
                }

            }
            //part 4

        string[] names = { "Jeme", "Moise", "Emily" };
            for (int m = 0; m < names.Length; m++)
            {
                if (names[m] == "Moise")
                {
                    Console.WriteLine(names[m]);

                }
            }
            Console.ReadLine();

            //part 5
        string[] names = { "Jeme", "Moise", "Emily" };
            for (int m = 0; m <= names.Length; m++)
            {
                if (names[m] == "Moise")
                {
                    Console.WriteLine(names[m]);

                }
            }
            Console.ReadLine();

            //part6
        List<string> notebook = new List<string>() { "doctor appointment", "family visit", "sister birthday" };
        Console.WriteLine("What do you want to know in your notebook? ");
        string note = Console.ReadLine();

        Console.WriteLine("You have  " + note);
        if (note == notebook)
        {
            Console.WriteLine("Anything else");

        }
        else
        {
            Console.WriteLine("Something went wrong!");
            Console.ReadLine();

                //part7


                //part8


                //part9

                //part10

                //part 11
        }
        


    }
}
    

