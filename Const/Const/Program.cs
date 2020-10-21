using System;

namespace Const
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Creating a const
            const string name = "Moise";
            //Create a variable using the keyword "var.”
            var i = 100;
          
        }
        // Chain two constructors together.
        public Program (): this(2)
        {

        }
        public Program(int name)
        {

        }
    }
}
