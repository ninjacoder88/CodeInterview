using CodeInterview.DataStructures;

namespace CodeInterview.Utility
{
    public class LinkedListDemo
    {
        public void Print(LinkedList<int> linkedList)
        {
            linkedList.AddNode(3);
            linkedList.AddNode(7);
            linkedList.AddNode(2);
            linkedList.AddNode(9);
            linkedList.Print();
        }
    }
}