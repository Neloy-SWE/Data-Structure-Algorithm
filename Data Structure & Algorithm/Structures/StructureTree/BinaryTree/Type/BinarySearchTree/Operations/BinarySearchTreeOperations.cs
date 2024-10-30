using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree.Type.BinarySearchTree.Operations
{
    internal class BinarySearchTreeOperations
    {
        //private static bool isFirst = true; 
        public static BinaryTreeNode InsertBSTNodeRecursive(BinaryTreeNode root, int data)
        {
            //if (isFirst)
            //{
            //    Console.WriteLine($"Binary search tree insertion executing a new node with data: {data}\n");
            //}
            if (root == null)
            {
                //Console.WriteLine("Insertion done!\n");
                root = new(data);
                //BinaryTreeShow.Get(root);
                return root;
            }

            if (data == root.data)
            {
                //Console.WriteLine("Duplicate value is not allowed!\n");
                return root;
            }
            //isFirst = false;
            if (data < root.data)
            {
                root.left = InsertBSTNodeRecursive(root.left, data);
            }
            else if (data > root.data)
            {
                root.right = InsertBSTNodeRecursive(root.right, data);
            }
            //Console.WriteLine("Insertion done!\n");
            //BinaryTreeShow.Get(root);
            return root;
        }

        public static BinaryTreeNode InsertBSTNodeIteration(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Binary search tree insertion executing a new node with data: {data}\n");
            BinaryTreeNode temporaryNode = new(data);

            if (root == null)
            {
                Console.WriteLine("Insertion done!\n");
                BinaryTreeShow.Get(temporaryNode);
                return temporaryNode;
            }

            BinaryTreeNode parentNode = null!;
            BinaryTreeNode currentNode = root;

            while (currentNode != null)
            {
                parentNode = currentNode;
                if (currentNode.data > data)
                {
                    currentNode = currentNode.left;
                }
                else if (currentNode.data < data)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    Console.WriteLine("Duplicate value is not allowed!\n");
                    return root;
                }
            }

            if (parentNode.data > data)
            {
                parentNode.left = temporaryNode;
            }
            else
            {
                parentNode.right = temporaryNode;
            }
            Console.WriteLine("Insertion done!\n");
            BinaryTreeShow.Get(root);
            return root;
        }
    }
}
