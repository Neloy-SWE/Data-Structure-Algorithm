using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree.Operations
{
    internal class BinaryTreeOperations
    {
        public static BinaryTreeNode Insert(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Binary tree insertion executing a new node with data: {data}\n");
            if (root == null)
            {
                Console.WriteLine("Insertion done!\n");
                return new(data);
            }

            BinaryTreeQueue queue = new();
            queue.Enqueue(root);

            while (queue.Count() > 0)
            {
                BinaryTreeNode node = queue.Dequeue();
                if (node.left == null)
                {
                    node.left = new(data);
                    break;
                }
                else
                {
                    queue.Enqueue(node.left);
                }

                if (node.right == null)
                {
                    node.right = new(data);
                    break;
                }
                else
                {
                    queue.Enqueue(node.right);
                }
            }
            Console.WriteLine("Insertion done!\n");
            BinaryTreeShow.Get(root);
            return root;
        }

        public static void SearchNode(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Searching node: {data}\n");

            if (root == null)
            {
                Console.WriteLine("Data not found!\n\n\n");
            }
            else
            {
                BinaryTreeQueue queue = new();

                queue.Enqueue(root);

                while (queue.Count() > 0)
                {
                    BinaryTreeNode node = queue.Dequeue();

                    if (node.data == data)
                    {
                        Console.WriteLine("Data found!\n\n\n");

                        return;
                    }

                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                Console.WriteLine("Data not found!\n\n\n");
            }
        }
    }
}
