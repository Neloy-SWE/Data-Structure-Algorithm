using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly.OperationCircularDoublyLinkedList
{
    internal class CircularDoublyDelete
    {
        public static CircularDoublyNode DeleteAtFront(CircularDoublyNode node)
        {
            Console.WriteLine("Delete at fornt:\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }
            if (node.next == node && node.previous == node)
            {
                Console.WriteLine("You deleted the last element of the list!\n");
                return null!;
            }

            CircularDoublyNode currentNode = node;
            currentNode = currentNode.next;
            currentNode.previous = currentNode.previous.previous;
            currentNode.previous.next = currentNode;
            node = currentNode;
            ShowLinkedList.ShowCircularDoubly(node, "Deleted at front:");
            return node;
        }

        public static CircularDoublyNode DeleteAtEnd(CircularDoublyNode node)
        {
            Console.WriteLine("Delete at end:\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }
            if (node.next == node && node.previous == node)
            {
                Console.WriteLine("You deleted the last element of the list!\n");
                return null!;
            }

            CircularDoublyNode currentNode = node.previous;

            currentNode.previous.next = currentNode.next;
            currentNode.next.previous = currentNode.previous;
            ShowLinkedList.ShowCircularDoubly(node, "Deleted at end:");
            return node;


        }

        public static CircularDoublyNode DeleteAfterNode(CircularDoublyNode node, int givenNode) {
            Console.WriteLine($"Delete after node: {givenNode}\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (currentNode.next != node && currentNode.data == givenNode)
                {
                    currentNode.next = currentNode.next.next;
                    currentNode.next.previous = currentNode;
                    ShowLinkedList.ShowCircularDoubly(node, "Deleted after given node:");
                    return node;
                }
                currentNode = currentNode.next;
            } while (currentNode != node);

            Console.WriteLine("Index out of bound!\n");
            return node;
        }
    }
}
