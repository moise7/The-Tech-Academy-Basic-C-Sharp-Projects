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


            List<Employee> employeeList = new List<Employee>()
        {
            new Employee(){empid = 1, firstname="Bill", lastname = "Jackson"},
            new Employee(){empid = 2, firstname="Moise", lastname = "Jess"},
            new Employee(){empid = 3, firstname="Hope", lastname = "Abdul"},
            new Employee(){empid = 4, firstname="Kristin", lastname = "Steva"},
            new Employee(){empid = 5, firstname="Jenny", lastname = "Ram"},
            new Employee(){empid = 6, firstname="Bork", lastname = "Hibail"},
            new Employee(){empid = 7, firstname="Billy", lastname = "Thoma"},
            new Employee(){empid = 8, firstname="Joe", lastname = "Wright"},
            new Employee(){empid = 9, firstname="Bob", lastname = "Jack"},
            new Employee(){empid = 10, firstname="Joe", lastname = "Wri"},


 };
            foreach (Employee emp in employeeList)
            {
                if(emp.firstname == "joe")
                {
                    Console.WriteLine("The employee name:  ");
                    Console.ReadLine();
                }
               

            }
            // Perform the same action again, but this time with a lambda expression.
            List<Employee> ListName =  employeeList.FindAll(x => (x.firstname == "Joe")).ToList())
            {
                Console.WriteLine("The employee name:  " + employeeList);
            }

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> ListId = employeeList.FindAll(x =>(x.empid > 5)).ToList())
                {
                Console.WriteLine("Name of all employee");
            }
        }
    }

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
    //    DaysOfTheWeek day;
    //    try {
    //        Console.WriteLine("Enter a day of the Week:  ");
    //        string value = Console.ReadLine();
    //        day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
    //        Console.WriteLine(day);
    //        Console.ReadLine();
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Try again Failed");
    //        Console.ReadLine();
    //        Console.WriteLine(ex.Message);
    //    }


    //}
    //public enum DaysOfTheWeek
    //{
    //    Monday = 1,
    //    Tuesday = 2,
    //    Wednesday = 3,
    //    Thursday = 4,
    //    Friday = 5,
    //    Saturday = 6,
    //    Sunday = 7
    //}

}
