using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            var firstNode = new Node(10);
            var secondNode = new Node(20);
            var thirdNode = new Node(30);
            //list.AddFirst(firstNode);
            //list.AddAfter(firstNode,secondNode);
            //list.AddAfter(secondNode, thirdNode);


            Stack S = new Stack(5);
            S.push(2);
            S.push(7);
            S.push(4);
            S.push(10);
            S.push(8);
            Console.WriteLine("Items are: ");
            S.print();

            S.pop();
            S.pop();



            Console.ReadLine();
        }
    }
}

