using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDDLinkedList;

namespace TDDLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new TDDLinkedList.LinkedList<int>();
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
        }
    }
}
