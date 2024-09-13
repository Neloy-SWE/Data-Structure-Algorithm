using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList
{
    internal class CircularInsert
    {
        public static CircularNode InsertInEmptyList(CircularNode node, int data)
        {

            Console.WriteLine("Insert in empty list:\n");
            if (node != null)
            {
                Console.WriteLine("Node is not empty!\n");
                return node;
            }
            CircularNode newNode = new(data);

            newNode.next = newNode;
            //ShowLinkedList.ShowCircular(newNode, "After insert the empty list");
            //return newNode; // returning newNode will create infinity loop.
            node = newNode;
            ShowLinkedList.ShowCircular(node, "After insert the empty list:");
            return node;
        }

        public static CircularNode InsertArFront(CircularNode node, int data)
        {
            Console.WriteLine("Insert at front:\n");
            CircularNode newNode = new(data);
            if (node == null)
            {
                newNode.next = newNode;
                return newNode;
            }

            newNode.next = node.next;
            node.next = newNode;
            ShowLinkedList.ShowCircular(node, "Inserted at front:");
            return node;
        }
    }
}
