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

           //IQuittable IQuitemployee = new Employee();
            Employee employee = new Employee();
            //IQuitemployee.Quit();
            Console.ReadLine();
            employee.SayName();
            employee.firstName = "sample";
            employee.lastName = "Student";
            Console.ReadLine();
        }
    }
}
