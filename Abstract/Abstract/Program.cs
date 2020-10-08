using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IQuittable employee = new Employee();
            employee.Quit();
            employee.firstName = "Luke";
            employee.lastName = "mat";
            Console.WriteLine(employee);
            Console.ReadLine();
        }
    }
}
