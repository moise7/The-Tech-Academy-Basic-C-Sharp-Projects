﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numArray = { 23, 56, 78, 67, 45, 88 };
                Console.WriteLine("Pick a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numArray.Count; i++)
                {
                    if (numArray[i] == num)
                        Console.WriteLine(numArray[i]);
                    Console.ReadLine();
                }
            }

    }
    }
}