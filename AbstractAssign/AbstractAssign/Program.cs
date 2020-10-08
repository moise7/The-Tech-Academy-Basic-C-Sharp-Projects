using System;

namespace AbstractAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable IQuitemployee = new Employee();
            IQuitemployee.Quit();
            Console.ReadLine();
        }
    }
}
