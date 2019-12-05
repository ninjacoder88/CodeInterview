namespace CodeInterview.DataStructures
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; set; }
    }

    public class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public BinaryTreeNode Left { get; set; }

        public BinaryTreeNode Right { get; set; }
    }
}