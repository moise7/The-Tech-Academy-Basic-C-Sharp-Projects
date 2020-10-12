using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssign
{
    public class Employee : Person, IQuittable
    {

        public void SayName()
        {
            Console.WriteLine("Your name: ");
        }


    }
}