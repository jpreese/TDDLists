using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLinkedList
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;

        public int Size { get; private set; }

        public LinkedListNode<T> AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>();
            node.Value = value;
            node.Next = head;

            head = node;

            Size++;

            return node;
        }

        public LinkedListNode<T> Get(int index)
        {
            var currentNode = head;
            for (var x = 0; x < index; x++)
            {
                if (HasNextNode(currentNode))
                {
                    currentNode = currentNode.Next;
                }
           } 

            return currentNode;
        }

        private bool HasNextNode(LinkedListNode<T> node)
        {
            return node.Next != null;
        }
    }
}
