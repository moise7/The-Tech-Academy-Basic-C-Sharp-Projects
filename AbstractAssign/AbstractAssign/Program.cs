using System;

namespace AbstractAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.ReadLine();
            employee.SayName();
            employee.firstName = "sample";
            employee.lastName = "Student";
            Console.ReadLine();
        }
    

    }
 }

