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

            Console.WriteLine(myTree.Root.Value);
            Console.WriteLine(lNode1.Value);
            Console.WriteLine(rNode1.Value);
            Console.WriteLine(lNode1.RightChild.Value);
            Console.WriteLine(rNode1.LeftChild.Value);
            Console.WriteLine(rNode1.RightChild.Value);

            myTree.PreOrder(myTree.Root);
            myTree.InOrder(myTree.Root);
            myTree.PostOrder(myTree.Root);
        }

        
    }
}
