using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree.Type.BinarySearchTree.Operations
{
    internal class BinarySearchTreeSearch
    {
        public static void Iteration(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Searching {data} in tree:\n");
            BinaryTreeNode currentNode = root;

            while (currentNode != null)
            {

                if (currentNode.data == data)
                {
                    Console.WriteLine($"data: {data} found in tree!\n\n");
                    return;
                }

                else if (currentNode.data < data)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    currentNode = currentNode.left;
                }
            }

            Console.WriteLine("Data not found!\n\n");
        }

        public static void Recursive(BinaryTreeNode root, int data)
        {
            if (root == null)
            {
                Console.WriteLine("Data not found!\n\n");
                return;
            }
            else if (root.data == data)
            {
                Console.WriteLine($"data: {data} found in tree!\n\n");
                return;
            }

            if (root.data < data)
            {
                Recursive(root.right, data);
            }
            else
            {
                Recursive(root.left, data);
            }
        }

    }
}
