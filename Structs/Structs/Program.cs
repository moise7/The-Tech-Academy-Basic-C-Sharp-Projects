﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number amount = new Number();
            amount.amount = 100;
            Console.WriteLine(amount.amount);
            Console.ReadLine();
        }
    }
}
