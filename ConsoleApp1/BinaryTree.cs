using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class BinaryTree
    {

        public BinaryTree(int value)
        {
            Root = new Node(value);
        }

        public Node Root { get; set; }

        public void InsertLeft(Node node, int value)
        {
            Node newChild = new Node(value);

            if (node.LeftChild == null)
            {
                node.LeftChild = newChild;
            }
            else
            {
                newChild.LeftChild = node.LeftChild;
                node.LeftChild = newChild;
            }
        }

        public void InsertRight(Node node, int value)
        {
            Node newChild = new Node(value);

            if (node.RightChild == null)
            {
                node.RightChild = newChild;
            }
            else
            {
                newChild.RightChild = node.RightChild;
                node.RightChild = newChild;
            }
        }

        public void PreOrder(Node node)
        {
            Console.WriteLine("P " + Convert.ToString(node.Value));
            if (node.LeftChild != null) { PreOrder(node.LeftChild); }
            if (node.RightChild != null) { PreOrder(node.RightChild); }
        }

        public void InOrder(Node node)
        {
            if (node.LeftChild != null) { InOrder(node.LeftChild); }
            Console.WriteLine("I " + Convert.ToString(node.Value));
            if (node.RightChild != null) { InOrder(node.RightChild); }
        }

        public void PostOrder(Node node)
        {
            if(node.LeftChild != null) { PostOrder(node.LeftChild); }
            if(node.RightChild != null) { PostOrder(node.RightChild); }
            Console.WriteLine("O " + Convert.ToString(node.Value));
        }
    }
}
