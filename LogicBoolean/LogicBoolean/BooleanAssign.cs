using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("What is your age?");
            
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 15)
            {
                Console.Write("Sorry, You are not qualifies for car insurance.\n");
                Console.Write("You need to be over 15 year.\n\n", 18 - age);
            }
            else
                Console.WriteLine("Congratulation! You are qualifies for a car insurance. Process!!\n\n");
            Console.ReadLine();
            

            Console.WriteLine("Have you ever had a DUI?");
            Console.ReadLine();
            bool condition = false;
            if (condition = true)
            {
                Console.WriteLine("Process....\n");

            }
            else {
                Console.WriteLine("Try again!!!\n");            
            }
            
            Console.WriteLine("How many speeding tickets do you have?");
            Console.ReadLine();
            int DUI;
            int speedingTickets = 0;

            Console.WriteLine("Have you ever had a DUI?");
            DUI = Convert.ToInt32(Console.ReadLine());
            int speedingTickects = Convert.ToInt32(Console.ReadLine());
            if (DUI == false && age < 15 && speedingTickects < 3)
            {
                Console.WriteLine("You Qualified. \n");
            }
            else
                Console.WriteLine("You can't proceed, try again!!!");
            Console.WriteLine("You selected" + age + "as your age");


        }
    }
}
