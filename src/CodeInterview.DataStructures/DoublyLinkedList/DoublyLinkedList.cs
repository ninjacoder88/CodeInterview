using System;

namespace CodeInterview.DataStructures.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Start { get; private set; }

        public DoublyLinkedListNode<T> Last { get; private set; }

        public void AddNode(DoublyLinkedListNode<T> node)
        {
            if(Start == null)
            {
                Start = node;
                Last = node;
                return;
            }

            Last.Next = node;
            node.Previous = Last;
            Last = node;
        }

        public DoublyLinkedListNode<T> RemoveNode()
        {
            if(Start == null)
            {
                return null;
            }

            if(Last == null)
            {
                return null;
            }

            if(Last.Previous == null)
            {
                var temp = Last;
                Start = null;
                Last = null;
                return temp;
            }

            throw new NotImplementedException();
        }
    }
}