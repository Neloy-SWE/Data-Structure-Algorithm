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
            Console.WriteLine("Binary tree insertion executing:\n");
            if (root == null)
            {
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
            return root;
        }
    }
}
