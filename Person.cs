using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unosquareCSharpConcepts
{

    public class Person
    {
        public FullName Name { get; set; }
    }

    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Write()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
