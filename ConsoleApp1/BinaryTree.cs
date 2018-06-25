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

        public int MaxPath { get; set; }

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
        //This iterates through the tree from root to the furthest left leaf
        //and then from root to furthest right leaf
        public void PreOrder(Node node)
        {
            Console.WriteLine("P " + Convert.ToString(node.Value));
            if (node.LeftChild != null) { PreOrder(node.LeftChild); }
            if (node.RightChild != null) { PreOrder(node.RightChild); }
        }

        //This starts at the furthest left leaf and traverses all the nodes to
        //the left of the root. Then it does the same for the nodes to the right of the root.        
        public void InOrder(Node node)
        {
            if (node.LeftChild != null) { InOrder(node.LeftChild); }
            Console.WriteLine("I " + Convert.ToString(node.Value));
            if (node.RightChild != null) { InOrder(node.RightChild); }
        }

        //This starts at the furthest left leaf and ends at the furthest right
        //but traverses the tree deepest level first
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null) { PostOrder(node.LeftChild); }
            if (node.RightChild != null) { PostOrder(node.RightChild); }
            Console.WriteLine("O " + Convert.ToString(node.Value));
        }

        public void LongestPath(int currentLongest, Node node)
        {
            //the longest path is the number of iterations that pass
            //the rule is that the current node value must be higher than its parent
            if (node.LeftChild != null && node.LeftChild.Value >= node.Value)
            {                
                LongestPath(currentLongest + 1 , node.LeftChild);             
            }
            else
            {                
                if (currentLongest > MaxPath){MaxPath = currentLongest;}
            }
            if (node.RightChild != null && node.RightChild.Value > node.Value)
            {
                LongestPath(currentLongest + 1, node.RightChild);                
            }
            else
            {                
                if (currentLongest > MaxPath){MaxPath = currentLongest;}
            }
        }

    }
}
