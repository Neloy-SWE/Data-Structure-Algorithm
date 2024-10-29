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
                Console.WriteLine("Duplicate value is not allowed!\n");
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
    }
}
