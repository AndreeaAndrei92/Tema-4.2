using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack
    {
        public int[] ele;
        public int top;
        public int max;
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                ele[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }
        }

        public void print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }
}
