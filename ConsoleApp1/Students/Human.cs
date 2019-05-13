using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    abstract class Human
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void print()
        {
            Console.WriteLine($"First Name={firstName}, Last Name={lastName}");
        }
    }
}
