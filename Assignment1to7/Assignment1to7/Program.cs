﻿using System;
using System.Collections.Generic;

namespace Assignment1to7
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a one-dimensional array of strings
            string[] movies = {"black panther", "Avengers", "X-man"};
               
            Console.WriteLine("type a text");
            //int i = Convert.ToInt32(Console.ReadLine());
            foreach(var item in movies)
            {
                Console.WriteLine(item);
                
            }
            //creating an infinite loop
            for(int a = 0; 0<50; a--)
            {
                Console.WriteLine("value:{0}", a);
            }
            //fixing the infinte loop
            for(int a = 0; 0 < 50; a++)
            {
                Console.WriteLine("value:{0}", a);
            }
            Console.ReadLine();
        }
        
       
       
    }
}