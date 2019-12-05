namespace CodeInterview.DataStructures
{
    public class DoublyLinkedList
    {
        public DoublyLinkedListNode Start { get; private set; }

        public DoublyLinkedListNode Last { get; private set; }

        public void AddNode(DoublyLinkedListNode node)
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

        public DoublyLinkedListNode RemoveNode()
        {
            if(Start == null)
            {
                return null;
            }

            
        }
    }

    public class DoublyLinkedListNode
    {
        public DoublyLinkedListNode(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public DoublyLinkedListNode Previous { get; set; }

        public DoublyLinkedListNode Next { get; set; }
    }
}