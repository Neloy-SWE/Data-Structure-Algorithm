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
        public static void InOrderDepthFirstSearch(BinaryTreeNode node)
        {
            // left - root/current - right
            if (node == null) return;
            InOrderDepthFirstSearch(node.left);
            Console.Write(node.data + " ");
            InOrderDepthFirstSearch(node.right);
        }

        public static void PreOrderDepthFirstSearch(BinaryTreeNode node)
        {
            // current/root - left - right
            if (node == null) return;
            Console.Write(node.data + " ");
            PreOrderDepthFirstSearch(node.left);
            PreOrderDepthFirstSearch(node.right);
        }

        public static void PostOrderDepthFirstSearch(BinaryTreeNode node)
        {
            // left - right - current/root
            if (node == null) return;
            PostOrderDepthFirstSearch(node.left);
            PostOrderDepthFirstSearch(node.right);
            Console.Write(node.data + " ");
        }

        public static void BreathFirstSearch(BinaryTreeNode root)
        {
            // level order
            BinaryTreeQueue queue = new();
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
