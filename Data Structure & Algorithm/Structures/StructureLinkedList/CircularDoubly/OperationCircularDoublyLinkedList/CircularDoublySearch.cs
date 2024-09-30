using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly.OperationCircularDoublyLinkedList
{
    internal class CircularDoublySearch
    {
        public static void ShowSpecificNode(CircularDoublyNode node, int nodeValue)
        {
            Console.WriteLine($"Show specific node {nodeValue}:\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
                return;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (currentNode.data == nodeValue)
                {
                    Console.WriteLine($"Node {nodeValue} is found!\n");
                    return;
                }
                currentNode = currentNode.next;
            } while (currentNode != node);

            Console.WriteLine($"Node {nodeValue} is not found!\n");
        }
    }
}
