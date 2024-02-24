using System;

namespace HackerRank.Solutions
{
    public class BinaryTreeFindMax
    {
        public void Execute()
        {
            var tree = new BinaryTree();
            tree.root = new Node(1);
            
            tree.root.left = new Node(2);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            tree.root.right = new Node(3);
            tree.root.right.left = new Node(14);
            tree.root.right.right = new Node(7);

            Console.WriteLine($"Maximum value is {tree.FindMax(tree.root)}");
            Console.ReadKey();
        }
    }

    public class BinaryTree
    {
        public Node root;

        public int FindMax(Node node)
        {
            if (node == null)
            {
                return int.MinValue;
            }

            int result = node.data;
            int leftResult = FindMax(node.left);
            int rightResult = FindMax(node.right);

            if (leftResult > result)
            {
                result = leftResult;
            }
            if (rightResult > result)
            {
                result = rightResult;
            }
            return result;
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int _data)
        {
            data = _data;
            left = null;
            right = null;
        }
    }
}
