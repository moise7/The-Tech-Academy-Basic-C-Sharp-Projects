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
            //Employee<string> employee = new Employee<string>();
            //employee.Things = new List<string>()
            //{
            ////    List<string> Things = new List<string>(new string[] {"23", "172","239"});
            ////List<int> int1 = Things.convertAll<int>(Convert.ToInt32);
            //"Appointement",
            //"Schedule",
            //"Date",
            //"Hours"
            //};
            //Employee<int> employees = new Employee<int>();
            //employees.Things = new List<int>()
            //{
            //    12, 23,45
            // };
            //foreach (string thing in employee.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //foreach(int things in employees.Things)
            //{
            //    Console.WriteLine(things);
            //}
            //Console.ReadLine();

            //Create an enum for the days of the week
            DaysOfTheWeek day;
            try {
                Console.WriteLine("Enter a day of the Week:  ");
                string value = Console.ReadLine();
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
                Console.WriteLine(day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Try again Failed");
                Console.ReadLine();
                Console.WriteLine(ex.Message);
            }
        }
        public enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday =3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
    }
}
