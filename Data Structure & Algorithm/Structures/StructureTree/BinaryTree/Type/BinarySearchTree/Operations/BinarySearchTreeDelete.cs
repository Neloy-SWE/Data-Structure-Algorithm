using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree.Type.BinarySearchTree.Operations
{
    internal class BinarySearchTreeDelete
    {
        public static BinaryTreeNode Iteration(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Binary search tree deletion executing the node with data: {data}\n");
            BinaryTreeNode currentNode = root;
            BinaryTreeNode previousNode = null!;

            while (currentNode != null && currentNode.data != data)
            {

                previousNode = currentNode;
                if (data < currentNode.data)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }

            if (currentNode == null)
            {
                Console.WriteLine($"{data} is not found!\n\n");
                return root;
            }

            if (currentNode.left == null || currentNode.right == null)
            {

                BinaryTreeNode newCurrentNode;

                if (currentNode.left == null)
                {
                    newCurrentNode = currentNode.right!;
                }
                else
                {
                    newCurrentNode = currentNode.left;
                }

                if (previousNode == null)
                {
                    return newCurrentNode;
                }

                if (currentNode == previousNode.left)
                {
                    previousNode.left = newCurrentNode;
                }
                else
                {
                    previousNode.right = newCurrentNode;
                }
            }
            else
            {
                BinaryTreeNode latestNode = null!;
                BinaryTreeNode temporaryNode = currentNode.right;

                while (temporaryNode.left != null)
                {
                    latestNode = temporaryNode;
                    temporaryNode = temporaryNode.left;
                }

                if (latestNode != null)
                {
                    latestNode.left = temporaryNode.right;
                }
                else
                {
                    currentNode.right = temporaryNode.right;
                }
                currentNode.data = temporaryNode.data;
            }
            Console.WriteLine("Deletion done!\n");
            BinaryTreeShow.Get(root);
            return root;
        }
    }
}
