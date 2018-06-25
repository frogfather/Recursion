using System;
using System.Collections;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree(3);
            myTree.InsertLeft(myTree.Root, 5);
            myTree.InsertRight(myTree.Root, 7);            

            Node lNode1 = myTree.Root.LeftChild;
            Node rNode1 = myTree.Root.RightChild;                        

            myTree.InsertRight(lNode1,6);
            myTree.InsertLeft(rNode1,9);            
            myTree.InsertRight(rNode1,2);
            myTree.InsertLeft(rNode1.LeftChild, 12);
            myTree.InsertRight(rNode1.LeftChild, 3);
            myTree.InsertLeft(rNode1.LeftChild.LeftChild, 14);
            myTree.InsertRight(rNode1.LeftChild.LeftChild, 6);

            myTree.PreOrder(myTree.Root);
            myTree.InOrder(myTree.Root);
            myTree.PostOrder(myTree.Root);
            myTree.MaxPath = 0;
            myTree.LongestPath(0, myTree.Root);
            Console.WriteLine("Longest path: {0}",myTree.MaxPath);
        }

        
    }
}
