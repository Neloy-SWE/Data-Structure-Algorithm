using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly.Operations
{
    internal class DoublyDelete
    {
        public static DoublyNode DeleteAtFront(DoublyNode node)
        {
            if (node == null)
            {
                Console.WriteLine("There is no node");
                return node!;
            }
            DoublyNode currentNode = node;

            if (currentNode.next != null)
            {
                currentNode = currentNode.next;
                currentNode.previous = null!;
                return currentNode;
            }
            else
            {
                return null!;
            }

        }

        public static DoublyNode DeleteAtEnd(DoublyNode node)
        {
            if (node == null || node.next == null)
            {
                return null!;
            }

            DoublyNode currentNode = node;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            if (currentNode.previous != null)
            {
                currentNode.previous.next = null!;
            }

            currentNode = null!;
            return node;
        }
    }
}
