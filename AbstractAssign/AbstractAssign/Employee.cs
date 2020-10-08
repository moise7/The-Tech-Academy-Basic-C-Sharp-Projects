using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssign
{
    class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Your name: ");
        }
    }
}
