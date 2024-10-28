using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree.Operations
{
    internal class BinaryTreeOperations
    {
        public static BinaryTreeNode InsertNode(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Binary tree insertion executing a new node with data: {data}\n");
            if (root == null)
            {
                Console.WriteLine("Insertion done!\n");
                return new(data);
            }

            BinaryTreeQueue<BinaryTreeNode> queue = new();
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

        public static BinaryTreeNode DeleteNode(BinaryTreeNode root, int data)
        {
            Console.WriteLine($"Binary tree deletion execution on node: {data}\n");
            if (root == null)
            {
                Console.WriteLine("Tree is empty!\n");
                return null!;
            }
            BinaryTreeQueue<BinaryTreeNode> queue1 = new();
            queue1.Enqueue(root);
            BinaryTreeNode targetNode = null!;

            while (queue1.Count() > 0)
            {
                BinaryTreeNode currentNode = queue1.Dequeue();
                if (currentNode.data == data)
                {
                    targetNode = currentNode;
                    break;
                }
                if (currentNode.left != null)
                {
                    queue1.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue1.Enqueue(currentNode.right);
                }
            }

            if (targetNode == null)
            {
                Console.WriteLine("Node not found\n");
                return root;
            }

            BinaryTreeNode lastNode = null!;
            BinaryTreeNode lastParentNode = null!;
            Queue<(BinaryTreeNode, BinaryTreeNode)> queue2 = new();
            queue2.Enqueue((root, null!));

            while (queue2.Count > 0)
            {
                var (currentNode, parentNode) = queue2.Dequeue();
                lastNode = currentNode;
                lastParentNode = parentNode;

                if (currentNode.left != null) queue2.Enqueue((currentNode.left, currentNode));
                if (currentNode.right != null) queue2.Enqueue((currentNode.right, currentNode));
            }

            targetNode.data = lastNode.data;
            if (lastParentNode != null)
            {
                if (lastParentNode.left == lastNode) 
                { 
                    lastParentNode.left = null!; 
                }
                else 
                { 
                    lastParentNode.right = null!; 
                }
            }
            else
            {
                Console.WriteLine("You remove the last node of the tree!\n");
                return null!;
            }
            Console.WriteLine("Deletion done!\n");
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
                BinaryTreeQueue<BinaryTreeNode> queue = new();

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
