using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree.Type.BinarySearchTree.Operations
{
    internal class BinarySearchTreeDelete
    {
        static bool isStart = true;
        public static BinaryTreeNode Iteration(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Binary search tree deletion executing the node with data: {data} (iteration)\n");
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

        public static BinaryTreeNode Recursive(BinaryTreeNode root, int data)
        {
            if (isStart)
            {
                Console.WriteLine($"Binary search tree deletion executing the node with data: {data} (recursive)\n");
                isStart = false;
            }
            if (root == null)
            {
                return root!;
            }

            if (root.data > data)
            {
                root.left = Recursive(root.left, data);
            }
            else if (root.data < data)
            {
                root.right = Recursive(root.right, data);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }

                if (root.right == null)
                {
                    return root.left;
                }

                //BinaryTreeNode successorNode = GetSuccessorNode(root);
                //root.data = successorNode.data;
                //root.right = Recursive(root.right, successorNode.data);

                BinaryTreeNode predecessorNode = GetPredecessorNode(root);
                root.data = predecessorNode.data;
                root.left = Recursive(root.left, predecessorNode.data);
            }
            //Console.WriteLine("Deletion done!\n");
            //BinaryTreeShow.Get(root);
            return root;
        }

        static BinaryTreeNode GetSuccessorNode(BinaryTreeNode currentNode)
        {
            currentNode = currentNode.right;
            while (currentNode != null && currentNode.left != null)
            {
                currentNode = currentNode.left;
            }
            return currentNode!;
        }

        static BinaryTreeNode GetPredecessorNode(BinaryTreeNode currentNode)
        {
            currentNode = currentNode.left;
            while (currentNode != null && currentNode.right != null)
            {
                currentNode = currentNode.right;
            }
            return currentNode!;
        }
    }
}
