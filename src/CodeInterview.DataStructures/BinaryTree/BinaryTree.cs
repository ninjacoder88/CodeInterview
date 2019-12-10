using System;

namespace CodeInterview.DataStructures.BinaryTree
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

            throw new NotImplementedException();
        }
    }
}