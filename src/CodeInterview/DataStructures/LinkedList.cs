using System;
using CodeInterview.Common.Interfaces;

namespace CodeInterview.DataStructures
{
    public class LinkedList<T>
    {
        public LinkedList(ILogger logger)
        {
            _logger = logger;
        }

        private LinkedListNode<T> Head { get; set; }

        private LinkedListNode<T> Tail { get; set; }

        public void AddNode(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            
            AddNode(newNode);
        }

        public void AddNode(LinkedListNode<T> node)
        {
            if(Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            Tail = node;
        }

        public LinkedListNode<T> RemoveNode()
        {
            throw new NotImplementedException();
        }

        public bool DoesLoopExist()
        {
            if(Head == null)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public void Print()
        {
            var current = Head;
            while(current != null)
            {
                _logger.Log(current.Value.ToString() + " -> ");
                current = current.Next;
            }
        }

        private ILogger _logger;
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;   
        }

        public T Value { get; }

        public LinkedListNode<T> Next { get; set; }
    }
}