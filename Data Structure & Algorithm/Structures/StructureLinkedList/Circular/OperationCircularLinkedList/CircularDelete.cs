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
            CircularNode nextNode = node;

            if (previousNode.next == previousNode)
            {
                node = null!;
                return null!;
            }

            while (previousNode.next != node)
            {
                previousNode = previousNode.next;
                nextNode = previousNode.next;
            }

            previousNode.next = nextNode.next;
            node = previousNode.next;
            ShowLinkedList.ShowCircular(node, "Deleted at front:");
            return node;
        }
    }
}
