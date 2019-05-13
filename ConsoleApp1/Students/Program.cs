using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ion", "Popescu", 7.2));
            students.Add(new Student("Vasile", "Popoivici", 4.38));
            students.Add(new Student("Maria", "Matei", 8.0));
            students.Add(new Student("Simona", "Surdu", 6.86));
            students.Add(new Student("Ioana", "Necula", 9.31));
            students.Add(new Student("Mihai", "Paduraru", 6.45));
            students.Add(new Student("Roxana", "Vedu", 8.49));
            students.Add(new Student("Ionut", "Nechifor", 7.62));
            students.Add(new Student("Radu", "Bujor", 7.52));
            students.Add(new Student("Mihaela", "Burlacu", 7.45));

            var sortStudents =
                from student in students
                orderby student.grade ascending
                select student;
            Console.WriteLine("Sorted list with students:");
            foreach (var elem in sortStudents)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();


            List<Worker> worker = new List<Worker>();
            worker.Add(new Worker("Vasile", "Roata", 500, 5));
            worker.Add(new Worker("Ion", "Bucur", 800, 10));
            worker.Add(new Worker("Maria", "Dumitru", 750, 8));
            worker.Add(new Worker("Irina", "Creanga", 840, 8));
            worker.Add(new Worker("Viorica", "Craciun", 600, 6));
            worker.Add(new Worker("Stefan", "Popescu", 650, 7));
            worker.Add(new Worker("Oana", "Neagu", 900, 8));
            worker.Add(new Worker("Dana", "Leonte", 760, 8));
            worker.Add(new Worker("Marian", "Dodan", 670, 6));
            worker.Add(new Worker("Andrei", "Cumpana", 780, 8));

            var sortWorker =
                from Worker in worker
                orderby worker.MoneyPerHour() descending
                select worker;
            Console.WriteLine("Sorted list with workers:");
            foreach (var elem in sortWorker)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();


            List<Human> mergeList = new List<Human>();
            mergeList.AddRange(students);
            mergeList.AddRange(worker);

            var sortMergeList =
                from human in mergeList
                orderby human.firstName ascending, human.LastName ascending
                select human;
            Console.WriteLine("Sorted list of humans:");
            foreach (var human in sortMergeList)
            {
                Console.WriteLine("Name: {0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
