/*
You are given the root of a binary search tree (BST) and an integer val.

Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null. 
*/

namespace Assignment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST tree = new();
            Node result;

            tree.Add(5);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.InOrderTraversal(tree.Root);
            Console.WriteLine();
            tree.Add(1);
            tree.Search(3, out result);
            tree.Search(30, out result);
        }
    }
}
