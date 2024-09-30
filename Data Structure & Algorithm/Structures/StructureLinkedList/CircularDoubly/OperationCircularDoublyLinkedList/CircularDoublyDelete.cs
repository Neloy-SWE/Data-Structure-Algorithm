using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly;
using System;
using System.Collections;
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

        public static CircularDoublyNode DeleteAfterNode(CircularDoublyNode node, int givenNode)
        {
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

        public static CircularDoublyNode DeleteBeforeNode(CircularDoublyNode node, int givenNode)
        {
            Console.WriteLine($"Delete before node: {givenNode}\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (node.data == givenNode)
                {
                    Console.WriteLine("Not possible to delete before first node!\n");
                    return node;
                }
                else if (currentNode.data == givenNode)
                {
                    if (currentNode.previous == node)
                    {
                        node = currentNode;

                    }
                    currentNode.previous = currentNode.previous.previous;
                    currentNode.previous.next = currentNode;
                    ShowLinkedList.ShowCircularDoubly(node, "Deleted before given node:");
                    return node;
                }
                currentNode = currentNode.next;

            } while (currentNode != node);
            Console.WriteLine("Given node is not found!\n");
            return node;
        }

        public static CircularDoublyNode DeleteSpecificNode(CircularDoublyNode node, int value)
        {
            Console.WriteLine($"Delete specific node: {value}\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (currentNode.data == value)
                {
                    if (currentNode.next == currentNode)
                    {
                        Console.WriteLine("You deleted the last node of the list!\n");
                        return null!;
                    }
                    currentNode.previous.next = currentNode.next;
                    currentNode.next.previous = currentNode.previous;
                    if (currentNode == node)
                    {
                        node = currentNode.next;
                    }
                    ShowLinkedList.ShowCircularDoubly(node, $"Node {value} is deleted!");
                    return node;
                }
                currentNode = currentNode.next;
            } while (currentNode != node);

            Console.WriteLine("Node is not found!\n");
            return node;
        }

        public static CircularDoublyNode DeleteAtSpecificIndex(CircularDoublyNode node, int index)
        {
            Console.WriteLine($"Delete specific position {index} node:\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            int count = 1;
            while (count <= index)
            {
                if (count == index)
                {
                    if (currentNode.next == currentNode)
                    {
                        Console.WriteLine("You deleted the last element of the list!\n");
                        return null!;
                    }
                    currentNode.previous.next = currentNode.next;
                    currentNode.next.previous = currentNode.previous;
                    if (currentNode == node)
                    {
                        node = currentNode.next;
                    }
                    ShowLinkedList.ShowCircularDoubly(node, $"Node at position {index} is deleted!");
                    return node;
                }
                currentNode = currentNode.next;
                if (currentNode == node)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine("Node is not found!\n");
            return node;
        }
    }
}
