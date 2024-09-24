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
            return node!;
        }
    }
}
