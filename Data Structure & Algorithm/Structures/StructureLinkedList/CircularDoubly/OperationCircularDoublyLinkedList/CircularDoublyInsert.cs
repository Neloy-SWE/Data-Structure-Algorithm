using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly.OperationCircularDoublyLinkedList
{
    internal class CircularDoublyInsert
    {
        public static CircularDoublyNode InsertAtFront(CircularDoublyNode node, int data)
        {
            Console.WriteLine("Insert at front:\n");
            CircularDoublyNode newNode = new(data);

            if (node == null)
            {
                Console.WriteLine("Node is empty! inserting the first node:\n");
                newNode.next = newNode;
                newNode.previous = newNode;
                node = newNode;
            }
            else
            {
                CircularDoublyNode currentNode = node.previous;
                newNode.next = node;
                newNode.previous = currentNode;
                node.previous = newNode;
                currentNode.next = newNode;
                node = newNode;
            }
            ShowLinkedList.ShowCircularDoubly(node, "Inserted at front:");
            return node;
        }

        public static CircularDoublyNode InsertAtEnd(CircularDoublyNode node, int data)
        {
            Console.WriteLine("Insert at end:\n");
            CircularDoublyNode newNode = new(data);

            if (node == null)
            {
                Console.WriteLine("Node is empty! inserting the first node:\n");
                newNode.next = newNode;
                newNode.previous = newNode;
                node = newNode;
            }
            else
            {
                CircularDoublyNode currentNode = node.previous;
                newNode.next = node;
                newNode.previous = currentNode;
                node.previous = newNode;
                currentNode.next = newNode;
            }
            ShowLinkedList.ShowCircularDoubly(node, "Inserted at end:");
            return node;
        }

        public static CircularDoublyNode InsertAfterNode(CircularDoublyNode node, int data, int nodeData)
        {
            CircularDoublyNode newNode = new(data);
            if (node == null)
            {
                Console.WriteLine("Node is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (currentNode.data == nodeData)
                {
                    newNode.next = currentNode.next;
                    newNode.previous = currentNode;

                    currentNode.next.previous = newNode;
                    currentNode.next = newNode;

                    if (currentNode == node.previous)
                    {
                        node.previous = newNode;
                    }
                    ShowLinkedList.ShowCircularDoubly(node, $"{data} is inserted after node: {nodeData}");
                    return node;
                }
                currentNode = currentNode.next;
            } while (currentNode != node);
            ShowLinkedList.ShowCircularDoubly(node, $"{data} is inserted after node: {nodeData}");
            return node;
        }
    }
}
