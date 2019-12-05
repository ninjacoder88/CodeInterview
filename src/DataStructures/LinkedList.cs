namespace CodeInterview.DataStructures
{
    public class LinkedList
    {
        public LinkedListNode Start { get; private set; }

        public LinkedListNode Last { get; private set; }

        public void AddNode(LinkedListNode node)
        {
            if(Start == null)
            {
                Start = node;
                Last = node;
                return;
            }

            Last.Next = node;
            Last = node;
        }

        public LinkedListNode RemoveNode()
        {
            if(Start == null)
            {
                return null;
            }

            
        }
    }

    public class LinkedListNode
    {
        public int Value { get; set; }

        public LinkedListNode Next { get; set; }
    }
}