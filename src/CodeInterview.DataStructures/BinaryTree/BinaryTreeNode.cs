namespace CodeInterview.DataStructures.BinaryTree
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }
    }
}