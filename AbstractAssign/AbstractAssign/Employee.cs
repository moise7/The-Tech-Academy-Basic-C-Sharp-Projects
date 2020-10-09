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
        public int Id { get; set; }
        public static bool operator ==(Employee empl1, Employee empl2)
        {
            
         
            bool result;
            if (empl1.Id == empl2.Id)
            {
                result = true;
                return result;


            }
            else
            {
                result = false;
                return result;
            }

        }
        public static bool operator !=(Employee empl1, Employee empl2)
        {
            return !(empl1 == empl2);
        }
    }
}
