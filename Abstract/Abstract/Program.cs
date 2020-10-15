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
            //Employee employee = new Employee();
            //employee.Quit();
            //Console.ReadLine();
            //employee.SayName();
            //employee.FirstName = "sample";
            //employee.LastName = "Student";
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>()
            {
            //    List<string> Things = new List<string>(new string[] {"23", "172","239"});
            //List<int> int1 = Things.convertAll<int>(Convert.ToInt32);
            "Appointement",
            "Schedule",
            "Date",
            "Hours"
            };
            Employee<int> employees = new Employee<int>();
            employees.Things = new List<int>()
            {
                12, 23,45
             };
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            foreach(int things in employees.Things)
            {
                Console.WriteLine(things);
            }
            Console.ReadLine();
        }
        
    }
}
