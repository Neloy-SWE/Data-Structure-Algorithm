using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList
{
    internal class CircularDelete
    {
        public static CircularNode DeleteAtFront(CircularNode node)
        {
            Console.WriteLine("Delete at front:\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }

            CircularNode previousNode = node;
            CircularNode tempNode = previousNode.next.next;

            if (previousNode.next == previousNode)
            {
                Console.WriteLine("You removed the last element!\n");
                node = null!;
                // though we initialize null to node,
                // but the node we sent to the paramenter for main function,
                // will be same if we do not re-initialize it in main function.
                return null!;
            }

            previousNode.next = tempNode;
            node = previousNode;

            ShowLinkedList.ShowCircular(node, "Deleted at front:");
            return node;
        }


        public static CircularNode DeleteAtEnd(CircularNode node)
        {
            Console.WriteLine("Delete at end:\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }

            CircularNode previousNode = node;

            if (previousNode.next == previousNode)
            {
                Console.WriteLine("You removed the last element!\n");
                node = null!;
                return null!;
            }

            while (previousNode.next != node)
            {
                previousNode = previousNode.next;
            }
            previousNode.next = node.next;
            node = previousNode;
            ShowLinkedList.ShowCircular(node, "Deleted at end:");
            return node;

        }
    }
}
