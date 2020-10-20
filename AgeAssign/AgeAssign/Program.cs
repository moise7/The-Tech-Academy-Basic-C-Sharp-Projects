using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AgeAssign
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you: ");
            int a = Convert.ToInt32(Console.ReadLine());

            DateTime currentDate = DateTime.Now;
            DateTime futureDate = currentDate.AddYears(-a);

            if (a <= 0)
            {
                throw new Exception();
                
            }
           

                Console.WriteLine("You were born in: " + futureDate.Year);
                
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact out support center we are 24/7");
         
            }
            Console.ReadLine();
        }
    }
}
