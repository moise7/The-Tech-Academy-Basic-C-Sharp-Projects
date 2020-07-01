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
            for (int i = 0; i < notebook.Count; i++)
            {
                if (notebook[i] == note)
                {
                    Console.WriteLine("Anything else");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    Console.WriteLine("Something went wrong!");


                    //part7


                   // part8 add to program


                //part9
                List<string> name = new List<string>() { "Moise", "krisitn", "Moise" };
                    Console.WriteLine("Select a name: ");
                    string names = Console.ReadLine();
                    Console.WriteLine("You selected  " + names);
                    for (int i = 0; i < name.Count; i++)
                    {
                        if (name[i] == names)
                        {
                            Console.WriteLine("Anything else");
                            Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                        Console.ReadLine();
                    }

                    part10

                    part 11
                }

            }

        }
    }



