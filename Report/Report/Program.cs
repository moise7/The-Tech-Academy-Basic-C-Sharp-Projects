using System;



    class Program
    {
 

    static void Main(string[] args)
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();
        //Questions
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("What course are you on? ");
        string course = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("What page number? ");
        string pageNumber = Console.ReadLine();
        Console.WriteLine("\n");

        bool confirmed = false;
        string help;
        do
        {
            Console.Write("Do you need help with anything? Please answer “true” or “false”.");
            help = Console.ReadLine();
            Console.WriteLine("You entered, " + help);

            ConsoleKey response;
            do
            {
                Console.Write("Are you sure you want to choose this ? [y/n] ");
                response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();

            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            confirmed = response == ConsoleKey.Y;
        } while (!confirmed);
        Console.WriteLine("You chose {0}!",help);
        Console.ReadLine();

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
        string feedback = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
        string qstion = Console.ReadLine();
        Console.ReadLine();

        Console.WriteLine("How many hours did you study today? ");
        string hours = Console.ReadLine();
        Console.ReadLine();

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
    }
