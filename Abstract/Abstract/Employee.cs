using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("Your name: ");
        }
        public void Quit()
        {
            throw new NotImplementedException();
        }

    }
}