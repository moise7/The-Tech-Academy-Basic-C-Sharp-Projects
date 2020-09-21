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
            int car = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected:" + car);
            // index that doesn’t exist message
            try
            {
                Console.WriteLine(cars);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Create a one-dimensional Array of integers
            int[] array = new int[5];
            array[0] = 4;
            array[1] = 6;
            array[2] = 14;
            array[3] = 16;
            array[4] = 26;
            Console.WriteLine("select a number from 0 to 4");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is:" + num);

            // index that doesn’t exist message
            try
            {
                Console.WriteLine(array[num]);
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
            Console.WriteLine("select a cars name from List");
            string result = string.Join(",", carList);
            Console.WriteLine($"RESULT: {result}");
            int List = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You selected:" + result);

            // index that doesn’t exist message
            try
            {
                Console.WriteLine(carList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
