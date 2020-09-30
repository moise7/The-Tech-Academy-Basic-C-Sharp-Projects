using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        Person person = new Person();
        public int Id { get; set; }
    }
}
