using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee<T>() : Person, IQuittable
    {
        public int Id { get; internal set; }

        public  void SayName()
        {
            Console.WriteLine("Your name: ");
        }
    public void Quit()
        {
            Console.WriteLine("Your name is:");
        }
        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator !=(Employee a, Employee b)
        {
            return a.Id != b.Id;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }
    public List<T> Things { get; set; }
    }
}

