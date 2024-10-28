using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * here we use recursion technique
 */

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree
{
    internal class BinaryTreeShow
    {
        public static void Get(BinaryTreeNode node)
        {
            Console.WriteLine("Showing binary tree\n");
            Console.Write("In order depth first search (left - root - right)::: ");
            InOrderDepthFirstSearch(node);
            Console.WriteLine("\n");

            Console.Write("Pre order depth first search (root - left - right)::: ");
            PreOrderDepthFirstSearch(node);
            Console.WriteLine("\n");

            Console.Write("post order depth first search (left - right - root)::: ");
            PostOrderDepthFirstSearch(node);
            Console.WriteLine("\n");

            Console.Write("Breath first search::: ");
            BreathFirstSearch(node);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }

        static void InOrderDepthFirstSearch(BinaryTreeNode node)
        {
            // left - root/current - right
            if (node == null) return;
            InOrderDepthFirstSearch(node.left);
            Console.Write(node.data + " ");
            InOrderDepthFirstSearch(node.right);
        }

        static void PreOrderDepthFirstSearch(BinaryTreeNode node)
        {
            // current/root - left - right
            if (node == null) return;
            Console.Write(node.data + " ");
            PreOrderDepthFirstSearch(node.left);
            PreOrderDepthFirstSearch(node.right);
        }

        static void PostOrderDepthFirstSearch(BinaryTreeNode node)
        {
            // left - right - current/root
            if (node == null) return;
            PostOrderDepthFirstSearch(node.left);
            PostOrderDepthFirstSearch(node.right);
            Console.Write(node.data + " ");
        }

        static void BreathFirstSearch(BinaryTreeNode root)
        {
            // level order
            BinaryTreeQueue<BinaryTreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count() > 0)
            {
                BinaryTreeNode node = queue.Dequeue();
                Console.Write(node.data + " ");
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
    }
}
