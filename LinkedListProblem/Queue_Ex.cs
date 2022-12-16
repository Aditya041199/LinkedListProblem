using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class Queue_Ex
    {
        Node rear;
        Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                rear = node;
                front = rear;
            }
            else
            {
                rear.Next = node;
                rear = rear.Next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.Write("|" + temp.data + "|");
                temp = temp.Next;
            }
        }
    }
}
