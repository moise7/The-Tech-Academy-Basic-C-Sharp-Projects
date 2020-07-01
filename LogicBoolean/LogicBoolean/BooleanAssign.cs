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
          
            Console.WriteLine("Have you ever had a DUI? Please enter true or false");
            bool DUI = false; 
            bool DUIs = Convert.ToBoolean(Console.ReadLine());
            if (DUI = false)
            {
                Console.WriteLine("Proceed...");
            }
            else
            {
                Console.WriteLine("Try again later");
            }
            Console.ReadLine();

            Console.WriteLine("How many speeding tickects do you have");
            int speedingTickects = Convert.ToInt32(Console.ReadLine());
            if (speedingTickects < 1)
            {
                Console.WriteLine("You can Proceed to see if you qualify");
            }
            else 
            {
                Console.WriteLine("Try again!!");
            }
            Console.ReadLine();

            //DUI = Convert.ToInt32(Console.ReadLine());
            
         
            if (DUIs = false && age < 15 && speedingTickects < 1)
            {
                Console.WriteLine("You Qualified. \n");
            }
            else
                Console.WriteLine("You can't proceed, try again!!!");
            Console.WriteLine("You selected " + age + " as your age");
            Console.ReadLine();

        }
        
    }
}
