using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main()
        {
            //Create a one-dimensional Array of strings
            string[] cars = { "BMW", "Ford", "Mazda" };
            Console.WriteLine("Select your car BMW, FORD or Mazda");
            string car = Console.ReadLine();
            Console.WriteLine("You selected:" + car);

            //Create a one-dimensional Array of integers
            int[] array = new int[5];
            Console.WriteLine("select a number from 1 to 5");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is:" + num);

            // index that doesn’t exist message
            try
            {
                Console.WriteLine([5]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Create a list of strings
            List<string> carList = new List<string>();
            carList.Add("Ferrari");
            carList.Add("BMW");
            carList.Add("Cameri");

        }
    }
}
