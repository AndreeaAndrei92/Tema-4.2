using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student : Human
    {
        public double grade { get; set; }

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        public void Print()
        {
            Console.WriteLine($"Grade={grade}");
        }
    }
}

