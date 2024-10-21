using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
