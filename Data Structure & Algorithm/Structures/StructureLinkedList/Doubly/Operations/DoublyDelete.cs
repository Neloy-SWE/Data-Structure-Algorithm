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

        public static DoublyNode DeleteAfterAGivenNode(DoublyNode node, int key)
        {
            DoublyNode currentNode = node;
            while (currentNode != null)
            {
                if (currentNode.data == key)
                {
                    break;
                }
                currentNode = currentNode.next;
            }

            if (currentNode == null || currentNode.next == null)
            {
                return node;
            }

            DoublyNode nextToDeleteNode = currentNode.next;

            currentNode.next = nextToDeleteNode.next;

            if (nextToDeleteNode.next != null)
            {
                nextToDeleteNode.next.previous = currentNode;
            }
            return node;
        }
    }
}
