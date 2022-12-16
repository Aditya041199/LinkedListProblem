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
            list.Addnote(10);
            list.Addnote(20);
            list.Addnote(30);
            list.Display();

            //list.Addreverse(10);
            //list.Addreverse(20);
            //list.Addreverse(30);
            //list.Display();

          
            list.DeleteLast();
            list.Display();

        }
    }
}