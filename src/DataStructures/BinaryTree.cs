namespace CodeInterview.DataStructures
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> Root { get; set; }

        public void AddNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            if(Root == null)
            {
                Root = new BinaryTreeNode<T>(value);
            }
        }
    }

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