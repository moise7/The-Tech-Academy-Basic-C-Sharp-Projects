using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssign
{
    interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Your name is:");
        }
    }
}
