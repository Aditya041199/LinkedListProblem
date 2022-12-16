using LinkedListProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //list.Addnote(10);
            //list.Addnote(20);
            //list.Addnote(30);
            //list.Display();

            //list.Addreverse(10);
            //list.Addreverse(20);
            //list.Addreverse(30);
            //list.Display();

          
            //list.DeleteLast();
            //list.Display();

            Stack_Ex stack_ = new Stack_Ex();
            //stack_.Push(10);
            //stack_.Push(20);
            //stack_.Push(30);
            //stack_.Peek();
            //stack_.Display();

            //stack_.Pop();

            //stack_.Display();
            //stack_.Pop();

            //stack_.Display();
            //stack_.Pop();

            //stack_.Display();

            Queue_Ex queue_Ex = new Queue_Ex();
            queue_Ex.Enqueue(10);
            queue_Ex.Enqueue(20);
            queue_Ex.Enqueue(30);
            queue_Ex.Enqueue(40);
            queue_Ex.Display();
        }
    }
}