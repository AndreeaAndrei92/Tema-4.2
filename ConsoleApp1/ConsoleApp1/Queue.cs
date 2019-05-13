using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Queue
    {
        public Node Head;
        public Node Tail;
        public int Count = 0;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                Tail.Next = newNode;
                Tail = Tail.Next;
            }
            Count++;
        }

        public int Dequeue()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            int result = Head.Data;
            Head = Head.Next;
            return result;
        }

    }

    public class Node
    {
        public int Data { get; set; }
        public int Next { get; set; }
        public Node(int data)
        {
            this.Data = data;
        }


    }
}
