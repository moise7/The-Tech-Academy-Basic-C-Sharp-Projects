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
            employee.Quit();
            Console.ReadLine();
            employee.SayName();
            employee.FirstName = "sample";
            employee.LastName = "Student";
            Console.ReadLine();
        }
        
    }
}
