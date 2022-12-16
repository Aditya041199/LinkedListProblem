using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Stack_Ex
    {
        Node top;
        public Stack_Ex()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", data);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.Next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0} is in the top of stack", top.data);
            }
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty deletion is not possible");
            }
            else
            {
                Console.WriteLine("Values popped is {0}", top.data);
                top = top.Next;
            }
        }
    }
}
